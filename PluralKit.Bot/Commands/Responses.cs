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
		
		public async Task Hello(Context ctx)
		{
			await ctx.Reply ("Hi! How are you? 👋💚");
		}
		
		public async Task Boo(Context ctx)
		{
			await ctx.Reply ("Gah! You scared me! :(");
		}
		
		public async Task ILoveYou(Context ctx)
		{
			await ctx.Reply ("Aww! I love you too! 💚");
		}
		
		public async Task Test(Context ctx)
		{
			await ctx.Reply ("Wait- How'd you get here? This was supposed to be a secret!");
		}
	}
}