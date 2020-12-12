using System.Threading.Tasks;

using DSharpPlus.Entities;

using PluralKit.Core;

namespace PluralKit.Bot
{
    public class GetStarted
    {
        public async Task ProxyHelp(Context ctx)
        {
            await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithTitle("Getting Started")
		.WithDescription("So you're new to proxybots and would like a tutorial on how to get started? Do not fear! I have one for you!\nClick [here](https://discord.com/channels/774580509854400522/775886244516593665/) to view it in the support server! (If you haven't joined the server yet [click here](https://discord.gg/NMcsKRvpns)! ). Alternatively you can click [here](https://proxymaster.carrd.co/#new) to view it on the Proxymaster support carrd!")
                .WithFooter($"By @Mushroom Kingdom#8404 | PluralKit by @Ske#620 https://github.com/xSke/PluralKit/")
                .WithColor(DiscordUtils.Green)
                .Build());
        }
	}
}