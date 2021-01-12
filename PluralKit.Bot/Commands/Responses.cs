using System.Threading.Tasks;

using DSharpPlus.Entities;

using PluralKit.Core;

namespace PluralKit.Bot
{
    public class Responses
	{
	
			public async Task ThankYou(Context ctx)
		{
			await ctx.Reply ($"**You have thanked me!**\n\nYou are very welcome, I am happy to be of use {Emojis.Hearts}!");
		}
	}
}