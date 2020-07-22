import React from 'react';

class ProductSlider extends React.Component {

  render() {
    const { title, image, fromColor, toColor} = this.props;
    
    return (   
      <div style={{width: '100%', height: '220px', padding: '0', borderRadius: '5px'}}>
        <img style={{width: '100%', height: '130px', borderRadius: '15px 15px 0 0', }} src={image} />
        <div style={{width: '100%', height: '90px', left: '0', bottom: '0', zIndex: '99', backgroundImage: 'linear-gradient(to left bottom, ' + fromColor + ', ' + toColor + ')', borderRadius: '0 0 15px 15px', opacity: '1'}}>
          <p style={{paddingTop: '30px', textAlign: 'center', fontSize: '15px', fontWeight: '300', color: '#fff' }}>
            {title.length > 20 ? title.substring(0, 20) + "...": title}
          </p>
        </div>
      </div>    
    );
  }
}

export default ProductSlider;
