import React from 'react';

import Banner from '../components/Banner'
import RegisterCard from '../components/RegisterCard'

import bgImage from "../assets/img/business_list.jpg"

const listData = [
  {
    monthly: 1,
    data: [
      {
        active: false,
        firstMoney: '0',
        lastMoney: 'R 50,000.00',
        title: 'Corporate',
        list: [
          { content: '2 Hrs Time Delay' },
          { content: 'Unlimited Category' },
          { content: 'Unlimited Users' },
          { content: '300 Requests' },
          { content: '50 Special' },
          { content: '50 E-Flyers' },
          { content: 'Unlimited Sales Lead' },
          { content: '100 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: '0',
        lastMoney: 'R 10,000.00',
        title: 'Franchisee',
        list: [
          { content: '3 Hrs Time Delay' },
          { content: '5 Category' },
          { content: '5 Users' },
          { content: '200 Requests' },
          { content: '25 Special' },
          { content: '25 E-Flyers' },
          { content: '50 Sales Lead' },
          { content: '50 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: true,
        firstMoney: '0',
        lastMoney: 'R 349.00',
        title: 'SME',
        list: [
          { content: '4 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '3 Users' },
          { content: '100 Requests' },
          { content: '10 Special' },
          { content: '10 E-Flyers' },
          { content: '10 Sales Lead' },
          { content: '10 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: '0',
        lastMoney: 'R 0.00',
        title: 'Free',
        list: [
          { content: '5 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '1 Users' },
          { content: 'No Requests' },
          { content: 'No Special' },
          { content: 'No E-Flyers' },
          { content: 'No Sales Lead' },
          { content: 'No Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      }
    ]
  },
  {
    monthly: 3,
    data: [
      {
        active: false,
        firstMoney: 'R150,000.00',
        lastMoney: 'R 142,500.00',
        title: 'Corporate',
        list: [
          { content: '2 Hrs Time Delay' },
          { content: 'Unlimited Category' },
          { content: 'Unlimited Users' },
          { content: '300 Requests' },
          { content: '50 Special' },
          { content: '50 E-Flyers' },
          { content: 'Unlimited Sales Lead' },
          { content: '100 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: 'R30,000.00',
        lastMoney: 'R 28,500.00',
        title: 'Franchisee',
        list: [
          { content: '3 Hrs Time Delay' },
          { content: '5 Category' },
          { content: '5 Users' },
          { content: '200 Requests' },
          { content: '25 Special' },
          { content: '25 E-Flyers' },
          { content: '50 Sales Lead' },
          { content: '50 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: true,
        firstMoney: 'R1,047.00',
        lastMoney: 'R 994.65',
        title: 'SME',
        list: [
          { content: '4 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '3 Users' },
          { content: '100 Requests' },
          { content: '10 Special' },
          { content: '10 E-Flyers' },
          { content: '10 Sales Lead' },
          { content: '10 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: '',
        lastMoney: 'R 0.00',
        title: 'Free',
        list: [
          { content: '5 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '1 Users' },
          { content: 'No Requests' },
          { content: 'No Special' },
          { content: 'No E-Flyers' },
          { content: 'No Sales Lead' },
          { content: 'No Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      }
    ]
  },
  {
    monthly: 6,
    data: [
      {
        active: false,
        firstMoney: 'R300,000.00',
        lastMoney: 'R 270,000.00',
        title: 'Corporate',
        list: [
          { content: '2 Hrs Time Delay' },
          { content: 'Unlimited Category' },
          { content: 'Unlimited Users' },
          { content: '300 Requests' },
          { content: '50 Special' },
          { content: '50 E-Flyers' },
          { content: 'Unlimited Sales Lead' },
          { content: '100 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: 'R60,000.00',
        lastMoney: 'R 54,000.00',
        title: 'Franchisee',
        list: [
          { content: '3 Hrs Time Delay' },
          { content: '5 Category' },
          { content: '5 Users' },
          { content: '200 Requests' },
          { content: '25 Special' },
          { content: '25 E-Flyers' },
          { content: '50 Sales Lead' },
          { content: '50 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: true,
        firstMoney: 'R2,094.00',
        lastMoney: 'R 1,884.60',
        title: 'SME',
        list: [
          { content: '4 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '3 Users' },
          { content: '100 Requests' },
          { content: '10 Special' },
          { content: '10 E-Flyers' },
          { content: '10 Sales Lead' },
          { content: '10 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: '',
        lastMoney: 'R 0.00',
        title: 'Free',
        list: [
          { content: '5 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '1 Users' },
          { content: 'No Requests' },
          { content: 'No Special' },
          { content: 'No E-Flyers' },
          { content: 'No Sales Lead' },
          { content: 'No Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      }
    ]
  },
  {
    monthly: 9,
    data: [
      {
        active: false,
        firstMoney: 'R450,000.00',
        lastMoney: 'R 382,500.00',
        title: 'Corporate',
        list: [
          { content: '2 Hrs Time Delay' },
          { content: 'Unlimited Category' },
          { content: 'Unlimited Users' },
          { content: '300 Requests' },
          { content: '50 Special' },
          { content: '50 E-Flyers' },
          { content: 'Unlimited Sales Lead' },
          { content: '100 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: 'R90,000.00',
        lastMoney: 'R 76,500.00',
        title: 'Franchisee',
        list: [
          { content: '3 Hrs Time Delay' },
          { content: '5 Category' },
          { content: '5 Users' },
          { content: '200 Requests' },
          { content: '25 Special' },
          { content: '25 E-Flyers' },
          { content: '50 Sales Lead' },
          { content: '50 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: true,
        firstMoney: 'R3,141.00',
        lastMoney: 'R 2,669.85',
        title: 'SME',
        list: [
          { content: '4 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '3 Users' },
          { content: '100 Requests' },
          { content: '10 Special' },
          { content: '10 E-Flyers' },
          { content: '10 Sales Lead' },
          { content: '10 Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      },
      {
        active: false,
        firstMoney: '',
        lastMoney: 'R 0.00',
        title: 'Free',
        list: [
          { content: '5 Hrs Time Delay' },
          { content: '3 Category' },
          { content: '1 Users' },
          { content: 'No Requests' },
          { content: 'No Special' },
          { content: 'No E-Flyers' },
          { content: 'No Sales Lead' },
          { content: 'No Keywords' },
          { content: 'CRM' },
          { content: 'PayFast Integration' }
        ]
      }
    ]
  }
]

class BusinessPackageSelectionPage extends React.Component {
  constructor(props) {
      super(props);
      this.state = {
        monthly: 1
      };
      this.selectPackageDuration = this.selectPackageDuration.bind(this);
  }

  selectPackageDuration(value){
    const { monthly } = this.state;
    if(value === 1){
      this.setState({monthly: 1})
    } else if(value === 3){
      this.setState({monthly: 3})
    } else if(value === 6){
      this.setState({monthly: 6})
    } else if(value === 9){
      this.setState({monthly: 9})
    }
    console.log(value);
  }
  render() {
    return (  
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Business Package Selection'}
        />
        <section class="breadcrumbs">
          <div class="container">
            <ul>
              <li><a href="/home-page">Home</a></li>
              <li><a href="">Business Registration</a></li>
            </ul>
          </div>
        </section>
        <section class="planing_section">
          <div class="container">
            <div class="text-center"><h1>Select Subscription Plan</h1></div>
            <div class="row" style={{marginTop: "50px"}}>
              <div class="col-md-12 text-center">
                <div class="tabs-wrapper"><div class="tabs enabled"><ul class="tab-list" role="tablist"></ul>                  
                  <ul class="tab-list" role="tablist">
                    <li class={this.state.monthly === 1 ? "tab active-tab" : "tab"} id="tablist1-tab1" aria-controls="tablist1-panel1" role="tab" tabindex="0"><b onClick={() => this.selectPackageDuration(1)} id="A1" class={this.state.monthly === 1 ? "clicked" : ""}>1 Month </b></li>
                    <li class={this.state.monthly === 3 ? "tab active-tab" : "tab"} id="tablist1-tab2" aria-controls="tablist1-panel2" role="tab" tabindex="0"><b onClick={() => this.selectPackageDuration(3)} id="A3" class={this.state.monthly === 3 ? "clicked" : ""}>3 Months (5% OFF)</b></li>
                    <li class={this.state.monthly === 6 ? "tab active-tab" : "tab"} id="tablist1-tab3" aria-controls="tablist1-panel3" role="tab" tabindex="0"><b onClick={() => this.selectPackageDuration(6)} id="A6" class={this.state.monthly === 6 ? "clicked" : ""}>6 Months (10% OFF)</b></li>
                    <li class={this.state.monthly === 9 ? "tab active-tab" : "tab"} id="tablist1-tab4" aria-controls="tablist1-panel4" role="tab" tabindex="0"><b onClick={() => this.selectPackageDuration(9)} id="A9" class={this.state.monthly === 9 ? "clicked" : ""}>9 Months (15% OFF) </b></li>
                  </ul>
                </div></div>
              </div>
              <div id="dvPackage" class="planing_area clearfix col-md-12 text-center" style={{marginTop: '50px'}}>
                <div class="row">
                {listData.map((item, key) => {
                  if(item.monthly === this.state.monthly){
                    return(
                      item.data.map((dataItem, dataKey) => {
                        return (
                          <RegisterCard
                            active={dataItem.active}
                            monthly={item.monthly}
                            firstMoney={dataItem.firstMoney}
                            lastMoney={dataItem.lastMoney}
                            title={dataItem.title}
                            list={dataItem.list}
                          />     
                        );}                      
                      )     
                    )
                  }
                })}
                </div>
              </div>
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default BusinessPackageSelectionPage;
