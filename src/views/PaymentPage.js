import React, { Component } from 'react';

class PaymentPage extends Component {

    componentDidMount = () => {
        const { paymentMethod } = this.props.location.state;
        console.log(paymentMethod);
    }

    render () {
        return (
            <div>
                <h1>PaymentPage</h1>
            </div>
        );
    }
}

export default PaymentPage;