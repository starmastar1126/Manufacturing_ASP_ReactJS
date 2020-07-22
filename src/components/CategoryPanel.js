import React, { Children } from 'react';
import { MDBIcon } from "mdbreact";

class CategoryPanel extends React.Component {

  render() {
    const { category, children} = this.props;
    
    return (   
      <div style={{backgroundColor: '#fff', padding: '10px 15px 10px 15px', marginTop: '20px', border: '1px solid #aaa', borderRadius: '5px'}}>
        <p style={{display: 'inline', float: 'left', fontSize: '16px', fontWeight: '500', color: '#000'}}>{category}</p>
        <div style={{backgroundColor: '#fff', padding: '10px 0px 10px 0px', marginTop: '40px', width: '100%', height: '100%', borderRadius: '5px'}}>
          <div class="container" style={{paddingTop: '0px'}}>
            {children}
          </div>
        </div>
      </div>
    );
  }
}

export default CategoryPanel;
