import React from 'react';

class MagazinesCard extends React.Component {
    render() {
        const { fromDate, toDate, image, company, suburb, category, description} = this.props;
        return (  
          <div className="col-md-6 col-sm-6 text-center">
            <div className="search_box clearfix">
              <div className="search_img">
                <a href={image}><img src={image} alt=""/></a>
                {/* <a href={image}><img src={image} alt=""/></a> */}
              </div>
              <div className="meta">
                <ul>
                  <li><a href="#">{company.length > 20 ? company.substring(0, 20) + "...": company}</a></li>
                  <li>{suburb.length > 20 ? suburb.substring(0, 20) + "...": suburb}</li>
                  <li>{fromDate}-{toDate}</li>
                </ul>
              </div>
              <h1>{category.length > 40 ? category.substring(0, 40) + "...": category}</h1>
              <div style={{height: '50px', overflow: 'hidden'}}>
                <p>{description}</p>
              </div>
              <div className="read_more">
                <a href="/view-magazines-details-page">Read More</a>
                <a href="#" className="contact_bussiness">Contact Business</a>
              </div>
            </div>
          </div>
        );
    }
}

export default MagazinesCard;
