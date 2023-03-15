using ChatzBlzor.Server.Models;
using ChatzBlzor.Shared;

namespace ChatzBlzor.Client.Managers
{
	public interface IChatManager
	{
		Task<List<ApplicationUser>> GetUsersAsync();
		Task SaveMessageAsync(ChatMessage message);
		Task<List<ChatMessage>> GetConversationAsync(string contactId);
		Task<ApplicationUser> GetUserDetailsAsync(string userId);
	}
}
