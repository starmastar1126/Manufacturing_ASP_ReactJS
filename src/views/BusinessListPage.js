import React from 'react';

import Banner from '../components/Banner'
import Select from '../components/Select'
import BusinessCard from '../components/BusinessCard'
import Pagenation from '../components/Pagenation'
import StockCa from '../components/StockCa'
import RequestItem from '../components/RequestItem'
import ContactDialog from '../components/ContactDialog';

import bgImage from "../assets/img/business_list.jpg"
import businessImage1 from "../assets/img/business1.jpeg"
import businessImage2 from "../assets/img/business2.jpg"
import businessImage3 from "../assets/img/business3.png"

import requestPng from '../assets/img/request_tyres_side.png'

const businessCardData = [
  {
    index: "1", 
    image: businessImage1,
    day: "20",
    month: "Jun",
    company: "New Age Plastics",
    suburb: "Johannesburg",
    category: "Chemicals",
    description: "Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b..."
  },
  {
    index: "2",
    image: businessImage2,
    day: "16",
    month: "Jun",
    company: "Rosh Products Manufacturers (Pty) Ltd Rosh Products Manufacturers (Pty) Ltd",
    suburb: "Johannesburg",
    category: "Chemicals",
    description: "Manufacturers of Detergines and food processed products."
  },
  {
    index: "3",
    image: businessImage3,
    day: "28",
    month: "Jun",
    company: "Statfurn cc",
    suburb: "Johannesburg",
    category: "Textiles, Clothing and Footwear, Clothing and Footwear",
    description: ""
  },
  {
    index: "4",
    image: businessImage1,
    day: "3",
    month: "Jul",
    company: "Speedchem",
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
        value: '1',
        content: 'Select Company'
      },
      {
        value: '2',
        content: 'One Company'
      }
    ]
  },
  {
    index: "2",
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
    index: "3",
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
    index: "4",
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
  },
  {
    index: "5",
    options: [
      {
        value: "0",
        content: "All Manufacturing"
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
  },
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

class BusinessListPage extends React.Component {

  constructor(props) {
      super(props);
      this.state = {
        showHideRequestItemState: false,
        contactVisible : false,
        contactCompany : ''
      };
      this.showHideRequestItemDialog = this.showHideRequestItemDialog.bind(this);
      this.contactHandler = this.contactHandler.bind(this);
  }

  showHideRequestItemDialog(){
    const { showHideRequestItemState } = this.state;
    if(showHideRequestItemState === false){
      this.setState({showHideRequestItemState: true});
    } else {
      this.setState({showHideRequestItemState: false})
    }
  }

  contactHandler() {
    const {contactVisible, contactCompany} = this.state;
    console.log(this.props.company);
    if(contactVisible === false){
        this.setState({contactVisible : true});
    } else {
        this.setState({contactVisible : false});
    }
  }

  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'View Business List'}
        />

        <section class="viewspecial ">
          <div class="container">
            <div class="topview topview_add clearfix">
              <h1>Search Filters</h1>
              <ul>
                {selectData.map((selectItem, selectKey) => {
                  return (
                    <li>
                      <div class={"sel_col"}>
                        <Select
                          index = {selectItem.index}
                          classes = "selectpicker"
                          options = {selectItem.options}
                        />
                        <i class="dropp_arrow"></i>
                      </div>
                    </li>
                  );}                      
                )}      
                <li>
                  <input class="input_search" type="submit" name="" id="" value="search"/>
                </li>                
              </ul>
            </div>
                
            <div class="search_list viewspecial_magazin">
              <div class="row">
                <div class="col-md-12">
                  <div class="row">
                    {businessCardData.map((businessCardItem, businessCardKey) => {
                      return (
                        <BusinessCard
                          index = {businessCardItem.index}
                          day = {businessCardItem.day}
                          month = {businessCardItem.month}
                          image = {businessCardItem.image}
                          company = {businessCardItem.company}
                          suburb = {businessCardItem.suburb}
                          category = {businessCardItem.category}
                          description = {businessCardItem.description}
                          contactHandler = {this.contactHandler}
                        />
                      );}                      
                    )}      
                  </div>
                  <Pagenation
                    count = {pagenationData}
                  />                
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
        <ContactDialog contactHandler = {this.contactHandler} visible = {this.state.contactVisible} />
      </div>
    );
  }
}

export default BusinessListPage;
