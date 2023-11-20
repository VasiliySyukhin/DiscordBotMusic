using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace DiscordBotMusic.Commands
{
    public class BasicCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task TestCommand(CommandContext ctx) 
        {
            await ctx.Channel.SendMessageAsync("Test Message");
        }
    }
}
