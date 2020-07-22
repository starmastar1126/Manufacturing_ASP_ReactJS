import React from 'react';
import ContactDialog from '../components/ContactDialog';

class BusinessCard extends React.Component {

  render() {
    const { day, month, image, company, suburb, category, description} = this.props;
    return (  
      <div class="col-md-4 col-sm-6">
        <div class="search_box clearfix">
          <div class="date">
            <span class="day">{day}</span>
            <span class="month">{month}</span>
          </div>
          <div class="search_img">
            <a href={image}><img src={image} alt=""/></a>
          </div>
          <div class="meta">
            <ul>
              <li><a href="#">{company.length > 45 ? company.substring(0, 45) + "...": company}</a></li><br/>
              <li>{suburb}</li>
            </ul>
          </div>
          <h1>{category.length > 30 ? category.substring(0, 30) + "...": category}</h1>
          <div style={{height: '100px', overflow: 'hidden'}}>
            <p>{description}</p>
          </div>
          <div class="read_more">
            <a href="/business-list-details-page">Read More</a>
            <a onClick={this.props.contactHandler} class="contact_bussiness">Contact Business</a>
          </div>
        </div>
      </div>
    );
  }
}

export default BusinessCard;
