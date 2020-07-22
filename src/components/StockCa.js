import React from 'react';

class StockCa extends React.Component {
    render() {
        const { title, list} = this.props;
        return (  
          <section class="stock_sa">
            <div class="container">
              <h1>{title}</h1>
              <select id="stocksa">                
                {list.map((item, key) => {
                  return (
                    <option value="">{item.content}</option>
                  );}                      
                )}      
              </select>
            </div>
          </section>  
        );
    }
}

export default StockCa;
