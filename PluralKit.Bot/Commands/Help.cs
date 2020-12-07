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

        public async Task Explain(Context ctx)
        {
		await ctx.Reply("Use any of the commands below to get a proper list of explanations!\n\n **pm!explainbot** = A small explanation of what the bot does and what proxying is \n **pm!introject** = Explanation about what Introjects are \n **pm!did** = Explanation on what DID/OSDD-1 is \n **pm!terms** = A list of system terms \n **pm!flag** = An explanation of the System Flag");
        }
		
		public async Task ExplainIntroject(Context ctx)
        {
            await ctx.Reply("Introjects are alters that take on the form of either fictional characters or real people. The ones that take on the form of fictional characters are called Fictional Introjects, the ones that take on the form of real people are called factual introjects. They are real alters, and form due to either positive or negative attachments, as well as corresponding trauma or stress. Contrary to popular belief, they don't only form during childhood, but can form just like any other alter that split after childhood.");
        }
		
		public async Task ExplainBot(Context ctx)
        {
            await ctx.Reply("Proxymaster is a bot made for systems (specifically people with DID/OSDD-1. View **pm!did** for more info on this). \n\nIt will take a message that has an affix attached to it and, if that affix is found in the databse, Proxymaster will use a webhook to help members of a system express themselves properly, by attaching a name as well as an avatar to the message. Due to discord limitations the webhooks have the [BOT] tag attached to it, though keep in mind these messages are being sent by real people. Please do not refer to them as bots.");
        }
		
		public async Task ExplainDID (Context ctx)
		{
			await ctx.Reply("DID, as well as OSDD-1a and OSDD-1b, are disorders that form in childhood, due to repeated trauma between the ages of 0-9. According to the theory of structural dissociation every person is born with separate 'states' which integrate after the age of 9. Due to the repeated trauma, however, the brain of the person with DID/OSDD-1 never integrated those states, instead the trauma disrupted the integration enough that they stayed separate. These 'states', often referred to as **Parts** or **Alters**, exist as a survival technique. In childhood, these states needed to be separate to protect the body, and so after childhood parts will still be seperate to protect the body and the system. Parts can have all kinds of roles in the system, not just protecting the body. For a list of terms look at **pm!terms** !");
		}
		
		public async Task ExplainTerms (Context ctx)
		{
			await ctx.Reply ("For a list of terms please visit the carrd linked below! https://system-terminology.carrd.co/ ");
		}
		
		public async Task ExplainFlag (Context ctx)
		{
		await ctx.Reply ($"Here is an explanation for the Black/Blue/Green/Yellow System Flag! \n\nThis flag is supposed to be an alternative to the White/Orange/Black one made by the Entropy System, as that flag, because of its colours and the day it was associated with, can be very triggering to Ritual Abuse survivors. Stripe meanings are as follows: \n\nBlack for Trauma/Dissociation \nBlue for people with DID/OSDD-1 who are unaware they have it \nGreen for people with DID/OSDD-1 who are aware they have it \nYellow for recovery, however that may look for you\n\n{Emojis.Flag}");
		}
		
		public async Task ThankYou(Context ctx)
		{
			await ctx.Reply ($"**You have thanked me!**\n\nYou are very welcome, I am happy to be of use {Emojis.Hearts}!");
		}
		
    }
}