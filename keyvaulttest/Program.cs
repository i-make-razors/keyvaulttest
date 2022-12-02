using Azure.Identity;

using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddEnvironmentVariables();

var envConfig = builder.Build();

var keyVaultUri = envConfig["KEYVAULT_URI"];

builder.AddAzureKeyVault(new Uri(keyVaultUri), new DefaultAzureCredential());

Console.WriteLine("Building Configuration");

var config = builder.Build();

var configValue = config["AzureKeyVaultTest"];

Console.WriteLine(configValue);