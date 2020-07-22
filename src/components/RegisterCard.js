import React from 'react';

class RegisterCard extends React.Component {
    render() {
        const { active, monthly, firstMoney, lastMoney, title, list} = this.props;
        return (  
          <div class="col-md-3">
            <div class={active === true ? "planing_details active_plan" : "planing_details"}>
              {(() => {
                switch (monthly) {
                  case 1:  return "";
                  case 3:  return (<div class='offering'>5% OFF</div>);
                  case 6:  return (<div class='offering'>10% OFF</div>);
                  case 9:  return (<div class='offering'>15% OFF</div>);
                  default:   return "";
                }
              })()}
              <h2>{title}</h2>
              <h3>
                {(() => {
                  if (monthly !== 1) {
                    return (<span class="linethrough">{firstMoney}</span>);
                  }  
                })()}
                 {lastMoney} <br/><span>Per {monthly} Month</span></h3>
              <ul>
                {list.map((item, key) => {
                  return (
                    <li>{item.content}</li>
                  );}                      
                )}      
              </ul>
              <a href="/business-registration-page">Subscribe</a>
            </div>
          </div>
        );
    }
}

export default RegisterCard;
