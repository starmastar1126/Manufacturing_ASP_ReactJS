import React, { Component } from 'react';

import * as Constants from '../../constants/Constants.js';

class PayPalPaymentPage extends Component {

    componentDidMount = () => {
        const { paymentMethod } = this.props.location.state;
        console.log(paymentMethod);
    }

    render () {
        return (
            <div>
                <form action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post" target="_top">
                    <input type="hidden" name="cmd" value="_xclick-subscriptions"/>
                    <input type="hidden" name="business" value={Constants.__TEST_PAYPAL_BUSINESS}/>
                    <input type="hidden" name="lc" value="US"/>
                    <input type="hidden" name="item_name" value="Billy"/>
                    <input type="hidden" name="item_number" value="sub1234567"/>
                    <input type="hidden" name="no_note" value="1"/>
                    <input type="hidden" name="src" value="1"/>
                    <input type="hidden" name="a3" value="42.00"/>
                    <input type="hidden" name="p3" value="1"/>
                    <input type="hidden" name="t3" value="M"/>
                    <input type="hidden" name="currency_code" value="USD"/>
                    <input type="hidden" name="bn" value="PP-SubscriptionsBF:btn_subscribeCC_LG.gif:NonHostedGuest"/>
                    <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_subscribeCC_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!"/>
                </form>
            </div>
        );
    }
}

export default PayPalPaymentPage;