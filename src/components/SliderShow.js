import React from 'react';

class SliderShow extends React.Component {
    render() {
        const { image, title1, title2, title3} = this.props;
        return (               
          <div class="ms-slide"> <img src={image} alt="lorem ipsum dolor sit"/>
            <h3 class="ms-layer slider-h3 full-width text-title"
                style={{left: '380px', top: '250px', right: '380px'}}
                data-type="text"
                data-delay="700"
                data-effect="skewleft(50,340)"
                data-ease="easeOutExpo"
                data-duration="2200"
                >{title1}</h3>
                            
            <h2 class="ms-layer slider-h3 full-width text-title"
                style={{left: '100px', top: '350px', right: '100px'}}
                data-type="text"
                data-delay="2000"
                data-effect="skewleft(50,340)"
                data-ease="easeOutExpo"
                data-duration="2200"
                >{title2}</h2>      
                            
            <p class="ms-layer text-text full-width text-center"
                style={{left: '300px', top: '430px', right: '300px'}}
                data-type="text"
                data-delay="3000"
                data-ease="easeOutExpo"
                data-effect="left(50)"
                data-duration="2300"
                >{title3}</p>        
          </div>
        )
    }
}

export default SliderShow;
