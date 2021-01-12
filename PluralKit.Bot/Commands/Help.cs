using System.Threading.Tasks;

using DSharpPlus.Entities;

using PluralKit.Core;

namespace PluralKit.Bot
{
    public class Help
    {
        public async Task HelpRoot(Context ctx)
        {
            await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithTitle("Proxymaster")
                .WithDescription("Proxymaster is a proxy bot with a focus on DID/OSDD-1 systems. It is meant to be a replacement for SystemTime! For more clarification join the support server here: https://discord.gg/NMcsKRvpns or check out the carrd: https://proxymaster.carrd.co/# .")
                .AddField("This Bot is a Fork of Pluralkit", "I take no ownership of any of the code taken from xSke for the PluralKit bot, and only do so of the code I added on my own, and of the modifications I did. https://github.com/xSke/PluralKit .")
				.WithFooter($"By @Mushroom Kingdom#8404 | PluralKit by @Ske#620 https://github.com/xSke/PluralKit/")
                .WithColor(DiscordUtils.Green)
                .Build());
        }
	}
}