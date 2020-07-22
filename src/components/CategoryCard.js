import React, { Children } from 'react';
import { MDBIcon } from "mdbreact";

class CategoryCard extends React.Component {

  render() {
    const { children} = this.props;
    
    return ( 
      <div>
        {children}
      </div>
    );
  }
}

export default CategoryCard;
