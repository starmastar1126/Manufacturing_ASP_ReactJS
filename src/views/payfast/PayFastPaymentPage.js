import React, { Component } from 'react';
import { Route, Redirect } from 'react-router-dom';

import * as Constants from '../../constants/Constants.js';

class PayFastPaymentPage extends Component {

    state = {
        payData: [
            { merchant_id: "10013798" },
            { merchant_key: "2gwwzibrczeui" },
            { return_url: "https://www.yoursite.com/return" },
            { cancel_url: "https://www.yoursite.com/cancel" },
            { notify_url: "https://www.yoursite.com/cancel" },

            { name_first: "John" },
            { name_last: "Doe" },
            { email_address: "sbtu01@payfast.co.za" },

            { m_payment_id: "h7hr6l9hv433ddf" },
            { item_name: "My Item" },
            { item_description: "Test product is OK!" },
            { amount: "5.5" },

            { subscription_type: "1" },
            { billing_date: "2019-07-27" },
            { recurring_amount: "10.00" },
            { frequency: "3" },
            { cycles: "0" },
            { passphrase: "Billy19930910" },
        ]
    }

    constructor(props) {
        super(props);

        this.handleSubmit = this.handleSubmit.bind(this);
    }

    componentDidMount = () => {
        const { paymentMethod } = this.props.location.state;
        console.log(paymentMethod);
    }

    handleSubmit(event) {
        event.preventDefault();

        // fetch("https://sandbox.payfast.co.za/eng/process",{
        //     method: "POST",
        //     body: JSON.stringify(this.state.payData),
        //     headers: {
        //         'Accept': 'application/json',
        //         'Content-Type': 'application/json'
        //     },
        // }).then(response => {
        //     response.json().then(data =>{
        //         console.log("Successful" + data);
        //     })
        // });
    }

    render () {
        return (
            <form action="https://sandbox.payfast.co.za/eng/process" >
                <input type="hidden" name="merchant_id" value={Constants.__TEST_PAYFAST_MERCHANT_ID} />
                <input type="hidden" name="merchant_key" value={Constants.__TEST_PAYFAST_MERCHANT_KEY} />
                <input type="hidden" name="return_url" value={Constants.__PAYFAST_RETURN_URL} />
                <input type="hidden" name="cancel_url" value={Constants.__PAYPAL_CANCEL_URL} />
                <input type="hidden" name="notify_url" value={Constants.__PAYFAST_NOTIFY_URL} />

                <input type="hidden" name="name_first" value="John" />
                <input type="hidden" name="name_last" value="Doe" />
                <input type="hidden" name="email_address" value="sbtu01@payfast.co.za" />

                <input type="hidden" name="m_payment_id" value="h7hr6l9hv433dy" />
                <input type="hidden" name="item_name" value="TestItem" />
                <input type="hidden" name="item_description" value="Testproduct" />
                <input type="hidden" name="amount" value="100.00" />
                <input type="hidden" name="signature" value="" />

                <input type="hidden" name="subscription_type" value="1" />
                <input type="hidden" name="billing_date" value="2019-07-26" />
                <input type="hidden" name="recurring_amount" value="09.10" />
                <input type="hidden" name="frequency" value="3" />
                <input type="hidden" name="cycles" value="0" />
                <input type="hidden" name="passphrase " value="Billy19930910" />

                <input type="submit" value="Submit"/>
            </form>
        );
    }
}

export default PayFastPaymentPage;