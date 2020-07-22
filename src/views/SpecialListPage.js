import React from 'react';

import Banner from '../components/Banner'
import Select from '../components/Select'
import SpecialCard from '../components/SpecialCard'
import Pagenation from '../components/Pagenation'
import StockCa from '../components/StockCa'

import bgImage from "../assets/img/special_list.jpeg"
import specialImage1 from "../assets/img/special_img1.jpg"
import specialImage2 from "../assets/img/special_img2.jpg"
import specialImage3 from "../assets/img/special_img3.jpg"

import requestPng from '../assets/img/request_tyres_side.png'
import RequestItem from '../components/RequestItem.js'

const specialCardData = [
  {
    index: "1", 
    image: specialImage1,
    company: "New Age Plastics Chemicals Chemicals",
    price: "R 500",
    suburb: "Johannesburg Johannesburg Johannesburg",
    category: "Chemicals Chemicals Chemicals Chemicals Chemicals",
    description: "Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b..."
  },
  {
    index: "2",
    image: specialImage2,
    company: "Rosh Products Manufacturers (Pty) Ltd",
    price: "R 500",
    suburb: "Johannesburg",
    category: "Chemicals",
    description: "Manufacturers of Detergines and food processed products."
  },
  {
    index: "3",
    image: specialImage3,
    company: "Statfurn cc",
    price: "R 500",
    suburb: "Johannesburg",
    category: "Textiles, Clothing and Footwear",
    description: ""
  },
  {
    index: "4",
    image: specialImage3,
    company: "Speedchem",
    price: "R 500",
    suburb: "Johannesburg",
    category: "Metals",
    description: ""
  }
]

const selectData = [
  {
    index: "1",
    options: [
      {
        value: "0",
        content: "All Companies"
      },
      {
        value: "1",
        content: "New Age Plastics"
      },
      {
        value: "2",
        content: "Rosh Products Manufacturers (Pty) Ltd"
      },
      {
        value: "3",
        content: "Statfurn cc"
      },
      {
        value: "4",
        content: "Speedchem"
      }
    ]
  },
  {
    index: "2",
    options: [
      {
        value: "0",
        content: "All Category"
      },
      {
        value: "1",
        content: "Aerospace  and  Defense"
      },
      {
        value: "2",
        content: "Arts  and  Grafts"
      },
      {
        value: "3",
        content: "Automotive Manufacturers"
      },
      {
        value: "4",
        content: "Chemicals"
      }
    ]
  },,
  {
    index: "3",
    options: [
      {
        value: "0",
        content: "All Province"
      },
      {
        value: "1",
        content: "Eastern Cape"
      },
      {
        value: "2",
        content: "Free State"
      },
      {
        value: "3",
        content: "Gauteng"
      },
      {
        value: "4",
        content: "KwaZulu Natal"
      }
    ]
  },
  {
    index: "4",
    options: [
      {
        value: "0",
        content: "All City"
      },
      {
        value: "1",
        content: "Alberton"
      },
      {
        value: "2",
        content: "Alexander Bay"
      },
      {
        value: "3",
        content: "Allen Grove"
      },
      {
        value: "4",
        content: "Amanzimtoti"
      }
    ]
  },
  {
    index: "5",
    options: [
      {
        value: "0",
        content: "All Suburb"
      },
      {
        value: "1",
        content: "11 Urtel Rd"
      },
      {
        value: "2",
        content: "138 Main Reef Rd"
      },
      {
        value: "3",
        content: "236 Zambezi Drive"
      },
      {
        value: "4",
        content: "366 Victoria Road"
      }
    ]
  }
]

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

const stockCaData = [
  {
    index: "1",
    content: "Manufacturing Companies in City of Johannesburg Metropolitan Municipality"
  },
  {
    index: "2",
    content: "Kolkata"
  },
  {
    index: "3",
    content: "Mumbai"
  }
]

class SpecialListPage extends React.Component {
  constructor(props) {
      super(props);
      this.state = {
        showHideRequestItemState: false
      };
      this.showHideRequestItemDialog = this.showHideRequestItemDialog.bind(this);
  }

  showHideRequestItemDialog(){
    const { showHideRequestItemState } = this.state;
    if(showHideRequestItemState === false){
      this.setState({showHideRequestItemState: true});
    } else {
      this.setState({showHideRequestItemState: false})
    }
  }
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'View Special List'}
        />
        <section class="viewspecial ">
          <div class="container">
            <div class="search_list viewspecial_magazin special_grid">
              <div class="row">
                <div class="col-md-8">
                  <div class="row">
                    {specialCardData.map((specialCardItem, specialCardKey) => {
                      return (
                        <SpecialCard
                          index = {specialCardItem.index}
                          image = {specialCardItem.image}
                          company = {specialCardItem.company}
                          price = {specialCardItem.price}
                          suburb = {specialCardItem.suburb}
                          category = {specialCardItem.category}
                          description = {specialCardItem.description}
                        />
                      );}                      
                    )}      
                    </div>
                    <Pagenation
                      count = {pagenationData}
                    />     
                  </div>

                  <div class="col-md-4">    
                    <div class="filter filter_area clearfix">
                      <h2>Search Filters</h2>
                      <div class="filter_form">
                      <form>            
                        <div class="form-group">
                          <label> Title</label>
                          <div>
                            <input type="text" class="form-control" id="" placeholder=""/>
                          </div>
                        </div>
                        
                        <div class="form-group ">
                          <label for="">Company</label>
                          <div>
                            {selectData.map((selectItem, selectKey) => {
                              if(selectItem.index === '1'){
                                return (
                                  <Select
                                    index = {selectItem.index}
                                    classes = "selectpicker"
                                    options = {selectItem.options}
                                  />
                              );}}                      
                            )}     
                          </div>
                        </div>
                        <div class="form-group ">
                          <label for="">Category</label>
                          <div>
                            {selectData.map((selectItem, selectKey) => {
                              if(selectItem.index === '2'){
                                return (
                                  <Select
                                    index = {selectItem.index}
                                    classes = "selectpicker"
                                    options = {selectItem.options}
                                  />
                              );}}                      
                            )}    
                          </div>
                        </div>
                        <div class="form-group ">
                          <label for="">Province</label>
                          <div>
                            {selectData.map((selectItem, selectKey) => {
                              if(selectItem.index === '3'){
                                return (
                                  <Select
                                    index = {selectItem.index}
                                    classes = "selectpicker"
                                    options = {selectItem.options}
                                  />
                              );}}                      
                            )}    
                          </div>
                        </div>
                        <div class="form-group ">
                          <label for="">City</label>
                          <div>
                            {selectData.map((selectItem, selectKey) => {
                              if(selectItem.index === '4'){
                                return (
                                  <Select
                                    index = {selectItem.index}
                                    classes = "selectpicker"
                                    options = {selectItem.options}
                                  />
                              );}}                      
                            )}    
                          </div>
                        </div>
                        <div class="form-group ">
                          <label for=""> Suburb </label>
                          <div>
                            {selectData.map((selectItem, selectKey) => {
                              if(selectItem.index === '5'){
                                return (
                                  <Select
                                    index = {selectItem.index}
                                    classes = "selectpicker"
                                    options = {selectItem.options}
                                  />
                              );}}                      
                            )}    
                          </div>
                        </div>              
                        <div class="form-group row">               
                          <div class="col-md-3">
                            <button type="submit" class="btn btn-primary checkout_sub_btt">Search</button>
                          </div>                
                        </div>              
                      </form>
                    </div>
                  </div>

                </div>    
              </div>
            </div>
          </div>
        </section>
        {/* <StockCa
          title = {'Manufacturing Companies in South Africa'}
          list = {stockCaData}
        /> */}
        <a onClick={this.showHideRequestItemDialog} id="menu-toggle"><img src={requestPng} alt=""/></a>
        <RequestItem showHideProps={this.state.showHideRequestItemState} />
      </div>
    );
  }
}

export default SpecialListPage;
