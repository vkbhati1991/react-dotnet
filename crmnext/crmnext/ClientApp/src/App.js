import React, { Component } from 'react';
// import { Route } from 'react-router';
import { Login } from './components/Login/Login';
// import { Layout } from './components/Layout';
// import { Home } from './components/Home';
// import { FetchData } from './components/FetchData';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Login />
      // <Layout>
      //   <Route exact path='/' component={Login} />
      //   <Route exact path='/Home' component={Home} />
      //   <Route path='/fetch-data' component={FetchData} />
      // </Layout>
    );
  }
}
