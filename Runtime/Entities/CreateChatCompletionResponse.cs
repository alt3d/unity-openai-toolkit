using System.Collections.Generic;

namespace OpenAIToolkit
{
    /// <summary>
    ///     Given a chat conversation, the model will return a chat completion response.
    ///     <a href="https://platform.openai.com/docs/api-reference/chat">See more</a>
    /// </summary>
    public class CreateChatCompletionResponse : BaseResponse
    {
        /// <summary>
        ///     The unique identifier.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        ///     Represents the time when the response was created. The value is expressed in Unix timestamp format.
        /// </summary>
        public int Created { get; internal set; }

        /// <summary>
        ///     The model used for the request.
        /// </summary>
        public string Model { get; internal set; }

        /// <summary>
        ///     The list of choices generated by the request.
        /// </summary>
        public List<ChatChoice> Choices { get; internal set; }

        /// <summary>
        ///     The usage information for the request.
        /// </summary>
        public Usage Usage { get; internal set; }
    }
}