using OpenAI_API;
using OpenAI_API.Chat;

OpenAIAPI api = new OpenAIAPI("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");

while (true)
{
    var chat = api.Chat.CreateConversation();
    Console.WriteLine("");
    var userInput = Console.ReadLine();
    chat.AppendUserInput(userInput);

    await foreach (var res in chat.StreamResponseEnumerableFromChatbotAsync())
    {
        Console.Write(res);
    }

    // the entire chat history is available in chat.Messages
    foreach (ChatMessage msg in chat.Messages)
    {
        Console.WriteLine($"{msg.Role}: {msg.Content}");
    }

    Console.WriteLine("Do you want to ask another question? (y/n)");
    var response = Console.ReadLine();
    if (response.ToLower() != "y")
    {
        break;
    }
}