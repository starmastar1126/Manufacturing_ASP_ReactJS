// import React from 'react';

import HomePage from './views/HomePage';
import ProductListPage from './views/ProductListPage';
import BusinessListPage from './views/BusinessListPage';
import BusinessListDetailsPage from './views/BusinessListDetailsPage';
import ViewMagazinesPage from './views/ViewMagazinesPage';
import ViewMagazinesDetailsPage from './views/ViewMagazinesDetailsPage';
import SpecialListPage from './views/SpecialListPage';
import SpecialListDetailsPage from './views/SpecialListDetailsPage';
import AboutUsPage from './views/AboutUsPage';
import CompetitionPage from './views/CompetitionPage';
import ContactUsPage from './views/ContactUsPage';
import BusinessPackageSelectionPage from './views/BusinessPackageSelectionPage';

import BusinessRegisterPaymentPage from './views/BusinessRegisterPaymentPage';
import BusinessRegistrationPage from './views/BusinessRegistrationPage';
import CartPage from './views/CartPage';
import LoginPage from './views/LoginPage';
import IndividualRegistrationPage from './views/IndividualRegistrationPage';
// import ProductsListPage from './views/ProductsListPage';

import PaymentPage from './views/PaymentPage';
import PayPalPaymentPage from './views/paypal/PayPalPaymentPage';
import PayPalCancelPage from './views/paypal/PayPalCancelPage';
import PayPalReturnPage from './views/paypal/PayPalReturnPage';
import PayFastPaymentPage from './views/payfast/PayFastPaymentPage';
import PayFastCancelPage from './views/payfast/PayFastCancelPage';
import PayFastNotifyPage from './views/payfast/PayFastNotifyPage';
import PayFastReturnPage from './views/payfast/PayFastReturnPage';

const routes = [
    { path: '/', exact: true, name: 'Home Page', component: HomePage },
    { path: '/home-page', name: 'Home Page', component: HomePage },
    { path: '/product-list-page', name: 'Product List Page', component: ProductListPage },
    { path: '/business-list-page', name: 'Business List Page', component: BusinessListPage },
    { path: '/business-list-details-page', name: 'Business List Details Page', component: BusinessListDetailsPage },
    { path: '/view-magazines-page', name: 'View Magazines Page', component: ViewMagazinesPage },
    { path: '/view-magazines-details-page', name: 'View Magazines Details Page', component: ViewMagazinesDetailsPage },
    { path: '/special-list-page', name: 'Special List Page', component: SpecialListPage },
    { path: '/special-list-details-page', name: 'Special List Details Page', component: SpecialListDetailsPage },
    { path: '/about-us-page', name: 'About Us Page', component: AboutUsPage },
    { path: '/competition-page', name: 'Competition Page', component: CompetitionPage },
    { path: '/contact-us-page', name: 'Contact Us Page', component: ContactUsPage },
    { path: '/business-package-selection-page', name: 'Business Package Selection Page', component: BusinessPackageSelectionPage },
    { path: '/business-register-payment-page', name: 'Business Register Payment Page', component: BusinessRegisterPaymentPage },
    { path: '/business-registration-page', name: 'Business Registration Page', component: BusinessRegistrationPage },
    { path: '/cart-page', name: 'Cart Page', component: CartPage },
    { path: '/login-page', name: 'Login Page', component: LoginPage },
    { path: '/individual-registration-page', name: 'Individual Registration Page', component: IndividualRegistrationPage },
    // { path: '/products-list-page', name: 'Products List Page', component: ProductsListPage },

    { path: '/payment-page', name: 'Payment Page', component: PaymentPage },
    { path: '/paypal-payment-page', name: 'PayPal Payment Page', component: PayPalPaymentPage },
    { path: '/paypal-cancel-page', name: 'PayPal Cancel Page', component: PayPalCancelPage },
    { path: '/paypal-return-page', name: 'PayPal Return Page', component: PayPalReturnPage },
    { path: '/payfast-payment-page', name: 'PayFast Payment Page', component: PayFastPaymentPage },
    { path: '/payfast-cancel-page', name: 'PayFast Cancel Page', component: PayFastCancelPage },
    { path: '/payfast-notify-page', name: 'PayFast Notify Page', component: PayFastNotifyPage },
    { path: '/payfast-return-page', name: 'PayFast Return Page', component: PayFastReturnPage },
];

export default routes;