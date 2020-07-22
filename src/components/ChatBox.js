import React from 'react';

class ChatBox extends React.Component {
  render() {
    return (
      <div class="chat-box">
        <div class="chat-closed"> Let us help you!! Live Chat </div>
        <div class="chat-header hide">Let us help you!! Live Chat</div>
        <div class="chat-content hide">
          <div class="chat-content-area">
            <div class="chat-details">
              Your chat content here...
            </div>
          </div>
          <form class="msger-inputarea">
            <input type="text" class="msger-input" placeholder="Enter your message..."/>
            <button type="submit" class="msger-send-btn">Send</button>
          </form>
        </div>
      </div>
    );
  }
}

export default ChatBox;
