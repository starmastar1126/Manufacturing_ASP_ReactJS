import React from 'react';

class Pagenation extends React.Component {
    render() {
        const { count} = this.props;
        return (  
          <div class="row text-center" style={{margin: 'auto'}}>
            <ul class="pagination_li">
              <li><a href="#">Prev</a></li>
              {count.map((countItem, countKey) => {
                return (
                  <li><a class={countItem.active === true ? 'active': ''} href="#">{countItem.i}</a></li>
                );}                      
              )}      
              <li><a href="#">Next</a></li>
            </ul>                
          </div>    
        );
    }
}

export default Pagenation;
