import React, { Component } from 'react';
import LoginFormFields from "./LoginFields";
import MnForm from '../../MnForm/MnForm';
import { LoginFormLayout } from "./LoginFormLayout";
import {postData} from "./LoginModal";

function LoginImage() {
    return (
        <div className="login-img">
            <img alt="" className="login-media" src="assets/images/l1.png" />
        </div>
    );
}

function LoginContent() {
    return (
        <React.Fragment>
            <div className="login-logo"> <img alt="" className="logo-media" src="assets/images/logo.svg" /></div>
            <div className="login-title">Welcome to <span className="brand">SchoolNext</span> Management System</div>
            <div className="login-subtitle">
                Access to the most powerfull School Management System in the world...
                            </div>
            <div className="login-text">Login</div>
        </React.Fragment>
    );

}

export class Login extends Component {
    render() {
        return (
            <div className="login-container">
                <div className="login-row">
                    {LoginImage()}
                    <div className="login-form bg-white">
                        <div className="login-contnet">
                            {LoginContent()}
                            <LoginFormComp />
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}


class LoginFormComp extends Component {

    static displayName = LoginFormComp.name;

    onSubmit = data => console.log(data);

    render() {
        return (
            <MnForm
                fields={LoginFormFields}
                postData={postData}
                layout={LoginFormLayout()}
                handleOnSubmit={this.onSubmit}
                actions={[{
                    text: "Login",
                    type: "Submit"
                }]}
            />
        );
    }
}