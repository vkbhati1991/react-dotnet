
import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import Notification from "./Context/Notification";

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <Notification>
    <BrowserRouter basename={baseUrl}>
      <App />
    </BrowserRouter>
  </Notification>,
  rootElement);


