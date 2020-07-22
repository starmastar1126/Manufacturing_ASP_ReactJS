import React from 'react';

import Banner from '../components/Banner'
import Pagenation from '../components/Pagenation'

import bgImage from "../assets/img/magazin_banner.jpeg"
import magazinImage from "../assets/img/magazin_details.png"
import categoryImage1 from "../assets/img/product_magazin_image1.jpg"
import categoryImage2 from "../assets/img/product_magazin_image2.jpg"
import categoryImage3 from "../assets/img/product_magazin_image3.png"
import categoryImage4 from "../assets/img/product_magazin_image4.jpg"

const pagenationData = [
  {
    i: "1", 
    active: false
  },
  {
    i: "2", 
    active: false
  },
  {
    i: "3", 
    active: true
  },
  {
    i: "4", 
    active: false
  },
  {
    i: "5", 
    active: false
  },
  {
    i: "...", 
    active: false
  },
  {
    i: "25", 
    active: false
  },
]

class ViewMagazinesDetailsPage extends React.Component {
  render() {
    return (
      <div>
      <Banner
        bgImage = {bgImage}
        title = {'View magazines Details'}
      />
      <section className="viewspecial viewspecial_magazin">
	      <div className="container">
          <div className="search_list">
        	  <div className="row">
            	<div className="col-md-9">
                <div className="business_details_area">
                  <div className="business_dtls_image"><img src={magazinImage} alt=""/></div>
                  <div className="business_details_content clearfix">
                    <ul className="clearfix">
                      <li><a>Posted by: <span id="lblAddress">Admin</span></a></li>                               
                    </ul>
                    <h2>Lorem Ipsum is simply dummy text</h2>
                    <ul className="clearfix">
                      <li><a>Status: <span id="lblStatus">Active</span></a></li>
                      <li><a>Started On: <span id="lblRegisteredDate">16-Jun-2015</span></a></li>
                      <li><a>End Date: <span id="lblRegisteredDate">30-Jun-2015</span></a></li>
                    </ul>
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur.</p>
                    <p>But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure.</p>
                  </div>
                  <br/>
                  <hr/>
                  <div className="business_contact">
                    <h3>Documents</h3>
                    <ul>
                      <li> <a href="assets/images/dummy_pdf.pdf" target="_blank"><i className="fa fa-file" aria-hidden="true"></i>Download Documents</a></li>
                    </ul>
                  </div>
                  <br/>
                  <hr/>
                </div>
              </div>
                
              <div className="col-md-3">
                <div className="filter filter_category clearfix">
                  <h2>Categories</h2>
                  <ul className="clearfix">
                    <li>
                      <div className="lft">
                        <p>Categories 1</p>
                      </div>
                      <div className="number">3</div>
                    </li>                        
                    <li>
                      <div className="lft">
                        <p>Categories 2 </p>
                      </div>
                      <div className="number">3</div>
                    </li>
                    <li>
                      <div className="lft">
                        <p>Categories 3</p>
                      </div>
                      <div className="number">3</div>
                    </li>
                    <li>
                      <div className="lft">
                        <p>Categories 4</p>
                      </div>
                      <div className="number">3</div>
                    </li>
                    
                    <li>
                      <div className="lft">
                        <p>Categories 5</p>
                      </div>
                      <div className="number">3</div>
                    </li>
                  </ul>
                </div>

                <div className="filter filter_category clearfix">
                  <h2> Rating</h2>
                  <div className="field">
                    <ul className="skill-bar">
                      <li>
                        <p>Excellent</p>
                        <div className="bar-wrap"><span data-width="0.00" style={{width: '50%'}}><strong style={{opacity: '1'}}>50%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Very Good</p>
                        <div className="bar-wrap"><span data-width="0.00" style={{width: '90%'}}><strong style={{opacity: '1'}}>90%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Good</p>
                        <div className="bar-wrap"><span data-width="0.00" style={{width: '30%'}}><strong style={{opacity: '1'}}>30%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Average</p>
                        <div className="bar-wrap"><span data-width="0.00" style={{width: '80%'}}><strong style={{opacity: '1'}}>80%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Poor</p>
                        <div className="bar-wrap"><span data-width="0.00" style={{width: '25%'}}><strong style={{opacity: '1'}}>25%</strong> </span></div>
                      </li>                
                    </ul>
                  </div> 
                </div>
              </div>
            </div>
          </div>
        </div>
      {/* </div> */}
      </section>

    <section className="related_product">
      <div className="container">
        <div className="heading">E-Catalogue By Other Company</div>
        <div className="related_product_slider">
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage1}><img src={categoryImage1} alt="Image"/></a>
              {/* <a href={cat1}><img src={cat1} alt="Image"/></a> */}
            </div>
            <h2><a href="#">simply dummy text </a></h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage2}><img src={categoryImage2} alt="Image"/></a>
              {/* <a href={cat2}><img src={cat2} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage3}><img src={categoryImage3} alt="Image"/></a>
              {/* <a href={cat3}><img src={cat3} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage4}><img src={categoryImage4} alt="Image"/></a>
              {/* <a href={cat4}><img src={cat4} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
      
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage1}><img src={categoryImage1} alt="Image"/></a>
              {/* <a href={cat1}><img src={cat1} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
      
          <div className="product_col">
            <div className="product_image">
              <a href={categoryImage2}><img src={categoryImage2} alt="Image"/></a>
              {/* <a href={cat2}><img src={cat2} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
        </div>
      </div>
    </section>

    <section className="review_section">
      <div className="container">
        <div className="business_contact review_details">
          <h3>Reviews on New Age Plastics</h3>
          <br/>
          <article className="type-post clearfix">
            <div className="entry-content content-thumbnail">
              <header className="entry-header">
                <h2 className="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div className="entry-meta">
                  <span className="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin
                    <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div className="star">
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                </div>
              </header>
              <div className="entry-desc">
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>
              </div>
            </div>
          </article>

          <article className="type-post clearfix">
            <div className="entry-content content-thumbnail">
              <header className="entry-header">
                <h2 className="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div className="entry-meta">
                  <span className="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin
                    <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div className="star">
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star-half-o" aria-hidden="true"></i>
                  <i className="fa fa-star-o" aria-hidden="true"></i>
                </div>
              </header>
              <div className="entry-desc">
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa . </p>
              </div>
            </div>
          </article>
          <article className="type-post clearfix">
            <div className="entry-content content-thumbnail">
              <header className="entry-header">
                <h2 className="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div className="entry-meta">
                  <span className="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin
                    <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div className="star">
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star" aria-hidden="true"></i>
                  <i className="fa fa-star-half-o" aria-hidden="true"></i>
                  <i className="fa fa-star-o" aria-hidden="true"></i>
                </div>
              </header>
              <div className="entry-desc">
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.</p>
              </div>
            </div>
          </article>
        </div> 
      </div>
    </section>
    </div>
    );
  }
}

export default ViewMagazinesDetailsPage;
