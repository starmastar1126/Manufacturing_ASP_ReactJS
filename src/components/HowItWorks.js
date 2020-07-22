import React from 'react';

class HowItWorks extends React.Component {
  render() {
    const { image, title, description} = this.props;
    return (      
      <div class="col-md-4">
        <div class="how_it_works_col">
          <div class="how_it_image"><img src={image} alt=""/></div>
          <h2>{title}</h2>
          <p>{description}</p>
        </div>
      </div>
    );
  }
}

export default HowItWorks;
