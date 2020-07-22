import React from 'react';

class ContactCard extends React.Component {
  render() {
    const { className, aLink, title, description} = this.props;
    return (  
      <div class="contact_info_col">
        <p>{title}</p>
        <a href={aLink}><i class={className} aria-hidden="true"></i> {description}</a>
      </div>
    );
  }
}

export default ContactCard;
