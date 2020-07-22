import React from 'react';
import ContactDialog from '../components/ContactDialog';

class BusinessCard extends React.Component {

  render() {
    const { day, month, image, company, suburb, category, description} = this.props;
    return (  
      <div className="col-md-4 col-sm-6">
        <div className="search_box clearfix">
          <div className="date">
            <span className="day">{day}</span>
            <span className="month">{month}</span>
          </div>
          <div className="search_img">
            <a href={image}><img src={image} alt=""/></a>
          </div>
          <div className="meta">
            <ul>
              <li><a href="#">{company.length > 45 ? company.substring(0, 45) + "...": company}</a></li><br/>
              <li>{suburb}</li>
            </ul>
          </div>
          <h1>{category.length > 30 ? category.substring(0, 30) + "...": category}</h1>
          <div style={{height: '100px', overflow: 'hidden'}}>
            <p>{description}</p>
          </div>
          <div className="read_more">
            <a href="/business-list-details-page">Read More</a>
            <a onClick={this.props.contactHandler} className="contact_bussiness">Contact Business</a>
          </div>
        </div>
      </div>
    );
  }
}

export default BusinessCard;
