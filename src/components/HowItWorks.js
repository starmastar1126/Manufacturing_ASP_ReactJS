import React from 'react';

class HowItWorks extends React.Component {
  render() {
    const { image, title, description} = this.props;
    return (      
      <div className="col-md-4">
        <div className="how_it_works_col">
          <div className="how_it_image"><img src={image} alt=""/></div>
          <h2>{title}</h2>
          <p>{description}</p>
        </div>
      </div>
    );
  }
}

export default HowItWorks;
