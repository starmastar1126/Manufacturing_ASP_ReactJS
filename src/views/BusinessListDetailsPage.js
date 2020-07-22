import React from 'react';

import Banner from '../components/Banner'
import Pagenation from '../components/Pagenation'

import bgImage from "../assets/img/business_list_details.jpeg"
import businessImage from "../assets/img/business_dtls_image.jpg"
import specialImage1 from "../assets/img/magagin21.jpg"
import specialImage3 from "../assets/img/ss2.jpg"
import specialImage2 from "../assets/img/ss.png"
import specialImage4 from "../assets/img/ss3.png"
import categoryImage1 from "../assets/img/cat1.jpg"
import categoryImage2 from "../assets/img/cat2.jpg"
import categoryImage3 from "../assets/img/cat3.png"
import categoryImage4 from "../assets/img/cat4.jpg"

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

class BusinessListDetailsPage extends React.Component {
  render() {
    return (
      <div>
      <Banner
        bgImage = {bgImage}
        title = {'View Business Details'}
      />
      <section class="viewspecial">
	      <div class="container">        
          <div class="search_list">
        	  <div class="row">
            	<div class="col-md-9">
                <div class="business_details_area">
                  <div class="business_dtls_image"><img src={businessImage} alt=""/></div>
                  <div class="business_details_content clearfix">
                    <h2>Lorem Ipsum is simply dummy text</h2>
                    <ul class="clearfix">
                      <li><a>Address:
                        <span id="lblAddress">Johannesburg,City of Johannesburg Metropolitan Municipality,Gauteng - 2091</span></a></li>
                      <li><a>Status:
                        <span id="lblStatus">Active</span></a></li>
                      <li><a>Reg. Date:
                        <span id="lblRegisteredDate">16-Jun-2015</span></a></li>
                    </ul>
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur.</p>
                    <p>But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure.</p>
                  </div>
                  <br/>
                  <hr/>
                  <div class="business_contact">
                    <h3>Contact Details</h3>
                    <ul>
                      <li>
                        <i class="fa fa-map-marker"></i>
                        34 Kindon Road Robersham,Johannesburg,City of Johannesburg Metropolitan Municipality,Gauteng - 2091 
                      </li>
                      <li>
                        <i class="fa fa-phone"></i>
                        0123456789
                      </li>
                      <li>
                        <i class="fa fa-envelope-o"></i>
                        <a href="#">example@gmail.com</a> 
                      </li>
                      <li>
                        <i class="fa fa-globe"></i>
                        <a href="#"> www.manufacturingezyfind.co.za </a> 
                      </li>                          
                    </ul>
                  </div>
                  <br/>
                  <hr/>
                </div>
              </div>
                
              <div class="col-md-3">
                <div class="filter filter_category clearfix">
                  <h2>Categories</h2>
                  <ul class="clearfix">
                    <li>
                      <div class="lft">
                        <p>Categories 1</p>
                      </div>
                      <div class="number">3</div>
                    </li>                        
                    <li>
                      <div class="lft">
                        <p>Categories 2 </p>
                      </div>
                      <div class="number">3</div>
                    </li>
                    <li>
                      <div class="lft">
                        <p>Categories 3</p>
                      </div>
                      <div class="number">3</div>
                    </li>
                    <li>
                      <div class="lft">
                        <p>Categories 4</p>
                      </div>
                      <div class="number">3</div>
                    </li>
                    
                    <li>
                      <div class="lft">
                        <p>Categories 5</p>
                      </div>
                      <div class="number">3</div>
                    </li>
                  </ul>
                </div>

                <div class="filter filter_category clearfix">
                  <h2> Rating</h2>
                  <div class="field">                  
                    <ul class="skill-bar">                        
                      <li>
                        <p>Excellent</p>
                        <div class="bar-wrap"><span data-width="0.00" style={{width: '50%'}}><strong style={{opacity: '1'}}>50%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Very Good</p>
                        <div class="bar-wrap"><span data-width="0.00" style={{width: '90%'}}><strong style={{opacity: '1'}}>90%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Good</p>
                        <div class="bar-wrap"><span data-width="0.00" style={{width: '30%'}}><strong style={{opacity: '1'}}>30%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Average</p>
                        <div class="bar-wrap"><span data-width="0.00" style={{width: '80%'}}><strong style={{opacity: '1'}}>80%</strong> </span></div>
                      </li>                  
                      <li>
                        <p>Poor</p>
                        <div class="bar-wrap"><span data-width="0.00" style={{width: '25%'}}><strong style={{opacity: '1'}}>25%</strong> </span></div>
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

      <section class="viewspecial magazin_list_page special_bhusiness">
        <div class="container">
          <div class="heading">Special By 3 M South Africa Pty Ltd No Special Found.</div>
          <br/>
          <div class="search_list viewspecial_magazin">
            <div class="row">
              <div class="col-md-12">
                <div class="row">
                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">                                
                      <div class="search_img">
                        <a href={specialImage1}><img src={specialImage1} alt=""/></a>
                        {/* <a href={magagin21}><img src={magagin21} alt=""/></a> */}
                      </div>     
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>
                    </div>
                  </div>
                    
                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">                          
                      <div class="search_img">
                        <a href={specialImage2}><img src={specialImage2} alt=""/></a>
                        {/* <a href={ss2}><img src={ss2} alt=""/></a> */}
                      </div>                      
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>
                    </div>
                  </div>
                    
                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">                        
                      <div class="search_img">
                        <a href={specialImage3}><img src={specialImage3} alt=""/></a>
                        {/* <a href={ss}><img src={ss} alt=""/></a> */}
                      </div>                      
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>                        
                    </div>
                  </div>
                  
                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">
                      <div class="search_img">
                        <a href={specialImage4}><img src={specialImage4} alt=""/></a>
                        {/* <a href={ss3}><img src={ss3} alt=""/></a> */}
                      </div>                      
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>                        
                    </div>
                  </div>

                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">                        
                      <div class="search_img">
                        <a href={specialImage1}><img src={specialImage1} alt=""/></a>
                        {/* <a href={magagin21}><img src={magagin21} alt=""/></a> */}
                      </div>     
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>                        
                    </div>
                  </div>
              
                  <div class="col-md-4 col-sm-6 text-center">
                    <div class="search_box clearfix">                          
                      <div class="search_img">
                        <a href={specialImage3}><img src={specialImage3} alt=""/></a>
                        {/* <a href={ss2}><img src={ss2} alt=""/></a> */}
                      </div>                  
                      <h1><a href="#">simply dummy text</a></h1>
                      <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo.</p>                          
                    </div>
                  </div>                    
                </div>
              </div>
                        
              <Pagenation
                count = {pagenationData}
              />    
            </div>
          </div>
        </div>
      {/* </div> */}
    </section>

    <section class="related_product">
      <div class="container">
        <div class="heading">E-Flyers / E-Catalogue By New Age Plastics</div>
        <div class="related_product_slider">
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage1}><img src={categoryImage1} alt="Image"/></a>
              {/* <a href={cat1}><img src={cat1} alt="Image"/></a> */}
            </div>
            <h2><a href="#">simply dummy text </a></h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage2}><img src={categoryImage2} alt="Image"/></a>
              {/* <a href={cat2}><img src={cat2} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage3}><img src={categoryImage3} alt="Image"/></a>
              {/* <a href={cat3}><img src={cat3} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
            
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage4}><img src={categoryImage4} alt="Image"/></a>
              {/* <a href={cat4}><img src={cat4} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
      
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage1}><img src={categoryImage1} alt="Image"/></a>
              {/* <a href={cat1}><img src={cat1} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
      
          <div class="product_col">
            <div class="product_image">
              <a href={categoryImage2}><img src={categoryImage2} alt="Image"/></a>
              {/* <a href={cat2}><img src={cat2} alt="Image"/></a> */}
            </div>
            <h2>simply dummy text</h2>
            <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
          </div>
        </div>
      </div>
    </section>

    <section class="review_section">
      <div class="container">
        <div class="business_contact review_details">
          <h3>Reviews on New Age Plastics</h3>
          <br/>
          <article class="type-post clearfix">
            <div class="entry-content content-thumbnail">
              <header class="entry-header">
                <h2 class="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div class="entry-meta">
                  <span class="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin 
                    <time class="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div class="star">
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                </div>
              </header>
              <div class="entry-desc">
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. </p>
              </div>
            </div>
          </article>

          <article class="type-post clearfix">
            <div class="entry-content content-thumbnail">
              <header class="entry-header">
                <h2 class="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div class="entry-meta">
                  <span class="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin 
                    <time class="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div class="star">
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star-half-o" aria-hidden="true"></i>
                  <i class="fa fa-star-o" aria-hidden="true"></i>
                </div>
              </header>
              <div class="entry-desc">
                <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa . </p>
              </div>
            </div>
          </article>
          <article class="type-post clearfix">
            <div class="entry-content content-thumbnail">
              <header class="entry-header">
                <h2 class="entry-title">
                  <a href="javascript:void(0);" rel="bookmark">Author Name</a>
                </h2>
                <div class="entry-meta">
                  <span class="posted-on">Posted By <a href="javascript:void(0);" rel="bookmark"> Admin 
                    <time class="entry-date published" datetime="2016-09-06T04:52:25+00:00"> June 30,2018</time>
                  </a></span>
                </div>
                <div class="star">
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star" aria-hidden="true"></i>
                  <i class="fa fa-star-half-o" aria-hidden="true"></i>
                  <i class="fa fa-star-o" aria-hidden="true"></i>
                </div>
              </header>
              <div class="entry-desc">
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

export default BusinessListDetailsPage;
