import React from 'react';

class ChatBox extends React.Component {

    render() {
        return (
            <div className="chat-box">
                <div className="chat-closed"> Let us help you!! Live Chat </div>
                <div className="chat-header hide">Let us help you!! Live Chat</div>
                <div className="chat-content hide">
                    <div className="chat-content-area">
                        <div className="chat-details">
                            Your chat content here...
                        </div>
                    </div>
                    <form className="msger-inputarea">
                        <input type="text" className="msger-input" placeholder="Enter your message..."/>
                        <button type="submit" className="msger-send-btn">Send</button>
                    </form>
                </div>
            </div>
        );
    }
}

export default ChatBox;
