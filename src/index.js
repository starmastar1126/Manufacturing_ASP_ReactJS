
import React from 'react';
import ReactDOM from 'react-dom';
import './assets/scss/index.css';
import Athena from './layouts/Athena';
import * as serviceWorker from './serviceWorker';

ReactDOM.render(<Athena />, document.getElementById('root'));

serviceWorker.unregister();
