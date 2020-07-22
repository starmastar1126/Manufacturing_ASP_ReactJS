import React from 'react';

class CategorySlider extends React.Component {

  render() {
    const { children} = this.props;
    
    return (      
      <div class="col-md-3">    
        <div class="slider-container" style={{width: '100%', height: '220px', padding: '0', borderRadius: '15px', boxShadow: '0 8px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)'}}>
          {children}
        </div>
      </div>
    );
  }
}

export default CategorySlider;
