import React from "react";
import { MDBCarousel, MDBCarouselCaption, MDBCarouselInner, MDBCarouselItem, MDBView, MDBMask, MDBContainer } from
"mdbreact";
import Button from "components/CustomButtons/Button.jsx";

import slideImage01 from "assets/img/athena/homepage/slider_camical.jpeg";
import slideImage02 from "assets/img/athena/homepage/slider_Electronics.jpeg";

const AthenaCarousel = () => {
  return (
      <MDBCarousel activeItem={1} length={2} showControls={true} showIndicators={true}>
        <MDBCarouselInner>
          <MDBCarouselItem itemId="1">
            <MDBView>
              <img src={slideImage01} style={{height: '50%', width: '100%', resizeMode: 'cover'}} />
              <MDBMask overlay="black-light" />
            </MDBView>
            <MDBCarouselCaption>
              <h3 style={{textAlign: 'center', width: '80%', marginLeft: '10%', marginRight: '10%', backgroundColor: '#af1928', padding: '1.0%', color: '#fff', textTransform: 'uppercase', borderRadius: '40% 0% 40% 0%'}}>Add your specials online</h3>
              <h3 style={{backgroundColor: '#e7e7e7', padding: '1.0%', color: '#333', fontWeight: 'bold', textTransform: 'uppercase', borderRadius: '40% 0% 40% 0%'}}>Show case your products or services</h3>
              <h5>View Specials here..</h5>
              <Button color="white" simple style={{border: 2, borderColor: '#fff'}}>
                SPECIALS
              </Button>
            </MDBCarouselCaption>
          </MDBCarouselItem>
          <MDBCarouselItem itemId="2">
            <MDBView>
              <img src={slideImage02} style={{height: '50%', width: '100%', resizeMode: 'cover'}} />
              <MDBMask overlay="black-light" />
            </MDBView>
            <MDBCarouselCaption>
              <h3 style={{textAlign: 'center', width: '80%', marginLeft: '10%', marginRight: '10%', backgroundColor: '#af1928', padding: '1.0%', color: '#fff', textTransform: 'uppercase', borderRadius: '40% 0% 40% 0%'}}>Search for any Business</h3>
              <h3 style={{backgroundColor: '#e7e7e7', padding: '1.0%', color: '#333', fontWeight: 'bold', textTransform: 'uppercase', borderRadius: '40% 0% 40% 0%'}}>in the Industrial and Manufacturing industry.</h3>
              <h5>Search by Company Name, Category or Location</h5>
              <Button color="white" simple style={{border: 2, borderColor: '#fff'}}>
                VIEW BUSINESSES
              </Button>
            </MDBCarouselCaption>
          </MDBCarouselItem>
        </MDBCarouselInner>
      </MDBCarousel>
  );
}

export default AthenaCarousel;
