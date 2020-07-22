import React from 'react';

import Banner from '../components/Banner'
import Pagenation from '../components/Pagenation'

import bgImage from "../assets/img/special_list_details.jpeg"
import specialImage from "../assets/img/product_magazin_image1.jpg"
import productImage from "../assets/img/product_magazin_image1.jpg"
import categoryImage1 from "../assets/img/search_img.jpg"
import categoryImage2 from "../assets/img/search_img2.jpg"
import categoryImage3 from "../assets/img/search_img3.jpg"

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

class SpecialListDetailsPage extends React.Component {
  render() {
    return (
      <div>
      <Banner
        bgImage = {bgImage}
        title = {'View Special Details'}
      />
      <section className="viewspecial viewspecial_magazin">
	      <div className="container">
          <div className="search_list">
        	  <div className="row">
            	<div className="col-md-6">
                <div className="special_view_image">
                  <div className="special_image"><img src={specialImage} alt=""/></div>
                </div>
              </div>
              <div className="col-md-6">
                <div className="special_details">
                  <h1>1 inch CAR A53</h1> 
                  <h2>Posted by <span >Mintys Sandton</span></h2>
                  <h2 className="price">Price: <span > R 0.00</span></h2>
                  <div className="list_under">
                    <div className="under_title">Listed Under</div>
                    <span id="lblCategory">Products &gt;&gt; Automotive &gt;&gt; Mags  or  Rims &gt;&gt; Mags New</span>
                  </div>
                  <div className="row date_col">
                    <div className="col-md-6">
                      <div className="under_title">Started From</div>
                      <span className="under_date">01-Jan-2018</span>
                    </div>
                    <div className="col-md-6">
                      <div className="under_title">Ending On</div>
                      <span className="under_date">01-Jan-2018</span>
                    </div>
                  </div>
                  <div className="pro_dtls">
                    <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.</p>
                  </div>
                  <div className="read_more">
                    <a href="#">Request Item</a>
                    <a href="#" className="contact_bussiness">Get Quotes</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </section>

<section className="viewspecial viewspecial_category viewspecial_category2">
  <div className="container">
    <div className="heading">Other Special By Mintys Sandton</div>
    <div className="search_list">
      <div className="row">
        <div className="col-md-3">
          <div className="filter filter_category clearfix">
            <h2>Special</h2>
            <ul className="clearfix">
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR01 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>15 INCH CAR167 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>15 INCH 168 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>CAR796 </p></a>
                </div>
              </li>    
              <li>
                <div className="lft">
                  <a href="#"> <p>15 inch CARB15 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>15 inch QCW134 </p></a>
                </div>
              </li>
              
              <li>
                <div className="lft">
                  <a href="#"><p>15 inch WORK WT004  </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR178 LIP </p></a>
                </div>
              </li>     
              <li>
                <div className="lft">
                    <a href="#"><p>17 inch CAR327 </p></a>
                </div>
              </li>              
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR770 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"> <p>15 inch CARB15 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>15 inch QCW134 </p></a>
                </div>
              </li>              
              <li>
                <div className="lft">
                  <a href="#"><p>15 inch WORK WT004  </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR178 LIP </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR327 </p></a>
                </div>
              </li>
              <li>
                <div className="lft">
                  <a href="#"><p>17 inch CAR770 </p></a>
                </div>
              </li>
            </ul>
          </div>
        </div>
        <div className="col-md-9">
          <div className="row">
            <div className="col-md-4">
              <div className="search_box">
                <a href="#">
                  <div className="search_img">
                    <img src={categoryImage1} alt=""/>
                  </div>
                  <h2>New Age Plastics</h2>
              </a>  
              </div>
            </div>          
            <div className="col-md-4">
              <div className="search_box">
                <a href="#">
                  <div className="search_img">
                    <img src={categoryImage2} alt=""/>
                  </div>
                  <h2>New Age Plastics</h2>
                </a>
              </div>
            </div>                    
            <div className="col-md-4">
              <div className="search_box">
                <a href="#">
                  <div className="search_img">
                    <img src={categoryImage3} alt=""/>
                  </div>
                  <h2>New Age Plastics</h2>
                </a>
              </div>
            </div>
                          
            <div className="col-md-4">
              <div className="search_box">
                <a href="#">
                  <div className="search_img">
                    <img src={categoryImage3} alt=""/>
                  </div>
                  <h2>New Age Plastics</h2>
                </a>
              </div>
            </div>    
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

<section className="related_product">
  <div className="container">
    <div className="heading">Special By Other Companies</div>
    <div className="related_product_slider">
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2><a href="#">simply dummy text </a></h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2>simply dummy text</h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2>simply dummy text</h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2>simply dummy text</h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2>simply dummy text</h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
      <div className="product_col">
        <div className="product_image">
          <a href={productImage}><img src={productImage} alt="Image"/></a>
          {/* <a href={magagin21}><img src={magagin21} alt="Image"/></a> */}
        </div>
        <h2>simply dummy text</h2>
        <p>Sed ut perspiciatis unde omnis iste natus error sit volup tatem</p>
      </div>
    </div>
  </div>
</section>


<section className="review_section filter_category_special">
  <div className="container">
    <div className="row">
      <div className="col-md-9">
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
                    <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00">June 30,2018</time>
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
                    <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00">June 30,2018</time>
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
                      <time className="entry-date published" datetime="2016-09-06T04:52:25+00:00">June 30,2018</time>
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
      <div className="col-md-3">
        <div className="filter filter_category clearfix">
          <h2> Overall Rating(0)  </h2>
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
</section>

      </div>
    );
  }
}

export default SpecialListDetailsPage;
