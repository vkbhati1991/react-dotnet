import React from 'react';
import { Switch } from 'react-router';
import { Layout } from "./components/Layout";
import { Login } from './components/Login/Login';
import { PrivateRouteLogin } from "./components/Routes/PrivateRouteLogin";
import { PrivateRoute } from "./components/Routes/PrivateRoute";
import { Dashboard } from "./components/Routes/Dashboard";
import { PageNotFound } from "./components/Routes/PageNotFound";
import { Logout } from "./components/Login/Logout";


export default function App() {
  return (
    <Switch>
      <PrivateRouteLogin exact path='/' component={Login} />
      <Layout>
        <Switch>
          <PrivateRoute exact path='/Dashboard' component={Dashboard} />
          <PrivateRoute exact path='/Logout' component={Logout} />
          <PrivateRoute exact path='*' component={PageNotFound} />
        </Switch>
      </Layout>
    </Switch>
  );
}
