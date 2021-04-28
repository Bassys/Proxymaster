using System.Threading.Tasks;

using DSharpPlus.Entities;

using PluralKit.Core;

namespace PluralKit.Bot
{
    public class MentalHealth
	{
	
		public async Task Attack (Context ctx)
		{
			await ctx.Reply ("Here are a few breathing patterns for you to try out!\n\n`Square Breathing`\n\n**Inhale** for 4 Seconds\n**Hold** for 4 Seconds\n**Exhale** for 4 Seconds\n**Hold** for 4 Seconds\n\n`4-7-8`\n\n**Inhale** for 4 Seconds\n**Hold** for 7 Seconds\n**Exhale** for 8 Seconds\n\n`Other Techniques`\n\nAlternate Nostril Breathing: Breathe in through one nostril and out the other\nAlternate Breathing: Breathe in through your nostril and out through your mouth\nSay **inhale** or **exhale** whenever you inhale and exhale");
		}
		
		public async Task Unreality (Context ctx)
		{
			await ctx.Reply ("You are real, the world around you is real. You exist, you matter. Your loved ones exist, your loved ones love you. You are alive, you are cherished. <:systemsunflower:828237130001285140>");
		}
		
		public async Task Hotlines (Context ctx)
		{
			await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithTitle("Hotlines")
				.WithDescription("Visit [this site](https://en.wikipedia.org/wiki/List_of_suicide_crisis_lines) for a list of crisis hotlines.\nAlternatively you can visit [7 Cups](https://www.7cups.com/) or [MellowTalk](https://mellowtalk.com/) for help online.")
                .WithFooter($"By @Mushroom Kingdom#8404 | Please stay safe! <3")
                .WithColor(DiscordUtils.Pink)
                .Build());
		}
		
		public async Task Grounding (Context ctx)
		{
			await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithTitle("Grounding Excercise")
				.WithDescription("[Click here](https://uquiz.com/quiz/l09UZQ/5-4-3-2-1-grounding-excercise) to get to an interactive 5-4-3-2-1 Grounding Excercise. [Click Here](https://www.bgcmd.org/wp-content/uploads/2020/03/Grounding-Exercise.pdf) for a solely text based version of this excercise.")
                .WithFooter($"By @Mushroom Kingdom#8404 | Please stay safe! <3")
                .WithColor(DiscordUtils.Pink)
                .Build());
		}
		
		public async Task Suicide (Context ctx)
		{
			await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithDescription("Here is a list of reasons [To Not KIll Yourself](https://medium.com/mona-loise/100-reasons-not-to-kill-yourself-247febd4054a). Here's [another one](https://www.girlsaskguys.com/social-relationships/a22392-100-reasons-to-why-you-shouldn-t-commit-suicide).\n\nHere are a bunch of [puppy gifs](https://giphy.com/search/puppy-gif).\n\nOr [kitten gifs](https://giphy.com/search/kitten) if that's what you like.\n\nPlease if you need to talk someone you can do `pm!mh hotlines` for a list of hotlines to call.\n\nHere are some [animal vines](https://www.youtube.com/watch?v=VB4CCHHYOqY) for you. Some other [funny vines](https://www.youtube.com/watch?v=fa-0MizbELk).\n\nYou're loved and valued. Please stay with us.")
                .WithFooter($"By @Mushroom Kingdom#8404 | Please stay safe! <3")
                .WithColor(DiscordUtils.Pink)
                .Build());
		}
		
		public async Task Loved (Context ctx)
		{
			await ctx.Reply ("You are loved and valued. You are such an amazing person, and I wish to see you thrive and succeed. You are incredible and I care for you. Please don't ever think you aren't lovely.");
		}
		
		public async Task Resources (Context ctx)
		{
			await ctx.Reply(embed: new DiscordEmbedBuilder()
                .WithTitle("Resources")
				.WithDescription("Here is a list of resources for you!\n\n[DID Resources](https://did-research.org/resources/)\n\n[Trauma Resources](https://www.complextrauma.org/resources/)\n\n[Dissociation Resources](https://www.aninfinitemind.com/resources.html)\n\n[General Mental Health Resources](https://www.counseling.org/knowledge-center/mental-health-resources)\n\n[Depression Resources](https://www.nimh.nih.gov/health/education-awareness/shareable-resources-on-depression.shtml)\n\n[ADHD Resources](https://add.org/adhd-resources/).\n\nIf you have some more resources, be sure to [send them in](https://forms.gle/82BDaPZmkDLoarqy8) so I can add them! This list is always expanding!")
                .WithFooter($"By @Mushroom Kingdom#8404 | Please stay safe! <3")
                .WithColor(DiscordUtils.Pink)
                .Build());
		}
	}
}