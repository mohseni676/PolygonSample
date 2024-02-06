using Nethereum.Web3;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts.CQS;
using Nethereum.Util;
using Nethereum.Web3.Accounts;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Contracts;
using Nethereum.Contracts.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Contracts.Standards.ERC20;
using Nethereum.ABI.Model;
using Nethereum.RPC;
using Nethereum.JsonRpc.Client;
using System.Numerics;
using Nethereum.RPC.Eth.DTOs;
namespace PolygonSample
{
    // Define a class for the balanceOf function parameters and output
    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public string Owner { get; set; }
    }

    // Define a class for the transfer function parameters and output
    [Function("transfer", "bool")]
    public class TransferFunction : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public string To { get; set; }

        [Parameter("uint256", "_value", 2)]
        public BigInteger Value { get; set; }
    }
    static class PolygonService
    {
        static Web3 web3 = new Web3("https://rpc-mumbai.maticvigil.com/"); // https://polygon-rpc.com/
        static string abi = @"[
  {
    ""inputs"": [
      {
        ""internalType"": ""address"",
        ""name"": ""who"",
        ""type"": ""address""
      }
    ],
    ""name"": ""balanceOf"",
    ""outputs"": [
      {
        ""internalType"": ""uint256"",
        ""name"": """",
        ""type"": ""uint256""
      }
    ],
    ""stateMutability"": ""view"",
    ""type"": ""function""
  },
  {
    ""inputs"": [
      {
        ""internalType"": ""address"",
        ""name"": ""_to"",
        ""type"": ""address""
      },
      {
        ""internalType"": ""uint256"",
        ""name"": ""_value"",
        ""type"": ""uint256""
      }
    ],
    ""name"": ""transfer"",
    ""outputs"": [
      {
        ""internalType"": ""bool"",
        ""name"": """",
        ""type"": ""bool""
      }
    ],
    ""stateMutability"": ""nonpayable"",
    ""type"": ""function""
  }
]";

        public static async Task<decimal> GetBalance(String address) {
            var result = await web3.Eth.GetBalance.SendRequestAsync(address);
            var amount = Web3.Convert.FromWei(result);
            return amount;
        }

        public static async Task<BalanceType> getContractBalance(String address, String contractAddress)
        {
            //var balance = await web3.Eth.ERC20.GetContractService(contractAddress).BalanceOfQueryAsync(address);
            //var converted_balance = Web3.Convert.FromWei(balance,6);

            //return converted_balance;
            BalanceType balanceType = new BalanceType();
            var balance = await web3.Eth.ERC20.GetContractService(contractAddress).BalanceOfQueryAsync(address);
            balanceType.decimalsOfToken = await web3.Eth.ERC20.GetContractService(contractAddress).DecimalsQueryAsync();
            balanceType.BalanceOfToken = Web3.Convert.FromWei(balance, balanceType.decimalsOfToken);
            balanceType.name = await web3.Eth.ERC20.GetContractService(contractAddress).NameQueryAsync();
            return balanceType;

        }

        public static async Task<TransactionReceipt> transferTokens(String walletPrivateKey, String contractAddress, string amount,String to)
        {
            Account account = new Account(walletPrivateKey);
            var tokenData = await getContractBalance(account.Address, contractAddress);
            if(double.Parse(amount) > double.Parse(tokenData.BalanceOfToken.ToString()))
            {
                throw new Exception("Transfer amount exceed of wallet balance");
            }
            var transferAmountToWei = Web3.Convert.ToWei(amount);//ToWeiFromUnit(BigInteger.Parse(amount),tokenData.decimalsOfToken);
            
            Web3 privateWeb3 = new Web3(account, "https://rpc-mumbai.maticvigil.com/");
            var transfer = await privateWeb3.Eth.ERC20.GetContractService(contractAddress).TransferRequestAndWaitForReceiptAsync(to,transferAmountToWei );

            
            return transfer;
            
        }
    }
}
