import React from 'react';

class SpecialCard extends React.Component {
    render() {
        const { image, company, suburb, price, category, description} = this.props;
        return (  
          <div class="col-md-4 col-sm-6">
            <div class="search_box clearfix">                    
              <div class="search_img">
                <a href={image}><img src={image} alt=""/></a>
                {/* <a href={image}><img src={image} alt=""/></a> */}
              </div>
              <div class="meta">
                <ul>
                  <li><a href="#">{company.length > 30 ? company.substring(0, 30) + "...": company}</a></li><br/>
                  <li>{suburb.length > 25 ? suburb.substring(0, 25) + "...": suburb}</li>
                </ul>
              </div>
              <div class="special_price"> Price: <span>{price}</span></div>
              <h1>{category.length > 20 ? category.substring(0, 20) + "...": category}</h1>
              <div style={{height: '100px', overflow: 'hidden'}}>
                <p>{description}</p>
              </div>
              <div class="read_more">
                <a href="#">Request Item</a>
                <a href="#" class="contact_bussiness">Get Quotes</a>
                <a href="/special-list-details-page" class="View_Details_a">View Details</a>
              </div>
            </div>
          </div>
        );
    }
}

export default SpecialCard;
