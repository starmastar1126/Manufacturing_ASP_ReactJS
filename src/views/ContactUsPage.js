import React from 'react';

import Banner from '../components/Banner'
import ContactCard from '../components/ContactCard'

import bgImage from "../assets/img/contact_us_banner.jpeg"

const contactCardData = [
  {
    index: "1", 
    className: "fa fa-map-marker",
    aLink: "#",
    title: "Office Address",
    description: "138 Delphinium Street Winchester Hills Ext 2 Johannesburg"
  },
  {
    index: "2", 
    className: "fa fa-envelope",
    aLink: "mailto:info@ezyfind.co.za",
    title: "Email ID",
    description: "info@ezyfind.co.za"
  },
  {
    index: "3", 
    className: "fa fa-phone",
    aLink: "#",
    title: "Phone Number",
    description: "+0 123 456 789"
  },
  {
    index: "4", 
    className: "fa fa-info",
    aLink: "#",
    title: "Online Support",
    description: "24/7 Support online chat."
  }
]

class ContactUsPage extends React.Component {
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Contact Us'}
        />
        
        <section class="contact_area">    
          <div class="container">
            <div class="heading">Contact Us</div>
            <div class="row">
              <div class="col-md-6">
                <div class="contact_info">
                  {contactCardData.map((contactCardItem, contactCardKey) => {
                    return (
                      <ContactCard
                        index = {contactCardItem.index}
                        className = {contactCardItem.className}
                        aLink = {contactCardItem.aLink}
                        title = {contactCardItem.title}
                        description = {contactCardItem.description}
                      />
                    );}                      
                  )}      
                </div>
              </div>
                  <div class="col-md-6">
                    <div class="contact_form">
                      <h2><span>Stay In</span> Touch</h2>
                      <form>
                        <div class="form-row">
                          <div class="form-group col-md-6">
                            <label for="">First Name*</label>
                            <input type="text" class="form-control" id="" placeholder=""/>
                          </div>
                          <div class="form-group col-md-6">
                            <label for="">Last Name*</label>
                            <input type="text" class="form-control" id="" placeholder=""/>
                          </div>
                        </div>
                        <div class="form-row">
                          <div class="form-group col-md-6">
                            <label for="">Phone</label>
                            <input type="text" class="form-control" id="" placeholder=""/>
                          </div>
                          <div class="form-group col-md-6">
                            <label for=""> Email*</label>
                            <input type="email" class="form-control" id="" placeholder=""/>
                          </div>
                        </div>                
                        <div class="form-row">
                          <div class="form-group col-md-12">
                            <label for="">Subject*</label>
                            <input type="text" class="form-control" id="" placeholder=""/>
                          </div>  
                        </div>
                        <div class="form-row">
                          <div class="form-group col-md-12">
                            <label for="">Message*</label>
                            <textarea class="form-control" id="exampleFormControlTextarea2" rows="3"></textarea>
                          </div>  
                        </div>
                        <div class="form-row">
                          <div class="col-md-12">
                            <button type="submit" class="sub_btt">SUBMIT</button>
                          </div>
                        </div>
                      </form>
                    </div>
                  </div>
                </div>
              </div>
            </section>
          </div>
        );
    }
}

export default ContactUsPage;
