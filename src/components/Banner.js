import React from 'react';

class Banner extends React.Component {
    render() {
        const { bgImage, title} = this.props;
        return (  
          <section className="tyre_bg" style={{backgroundImage: "url(" + bgImage + ")"}}>
            <h1>{title}</h1>
          </section>
        );
    }
}

export default Banner;
