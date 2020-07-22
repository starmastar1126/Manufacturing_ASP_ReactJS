import React from 'react';

class HowItsWorks extends React.Component {
    render() {
        const { image, index, title, description} = this.props;
        return (               
            <div className="col-md-6 margin_bt">
              <div className="row">
                <div className="col-md-3"><img src={image} alt=""/></div>
                <div className="col-md-9 padding_l">
                  <h4>STEP - {index}</h4>
                  <h3>{title} </h3>
                  <p>{description} </p>
                </div>
              </div>
            </div>
        );
    }
}

export default HowItsWorks;
