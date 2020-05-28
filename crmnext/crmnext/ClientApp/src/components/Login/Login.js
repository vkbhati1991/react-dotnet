import React, { Component } from 'react';

export class Login extends Component {
    static displayName = Login.name;

    render() {
        return (
            <div className="login-container">
                <div className="login-row">
                    <div className="login-img">
                        <img alt="" className="login-media" src="assets/images/l1.png" />
                    </div>
                    <div className="login-form bg-white">
                        <div className="login-contnet">
                            <div className="login-logo"> <img alt="" class="logo-media" src="assets/images/logo.svg" /></div>
                            <div className="login-title">Welcome to <span class="brand">SchoolNext</span> Management System</div>
                            <div className="login-subtitle">
                                Access to the most powerfull School Management System in the world...
                            </div>
                            <div className="login-text">Login</div>
                            <div className="form-signin">
                                <div className="login-form-row">
                                    <div className="input-group">
                                        <input type="text" name="username" className="form-control" placeholder="E-mail id" id="id_username" />
                                    </div>
                                </div>
                                <div class="login-form-row">
                                    <div class="input-group">
                                        <input type="password" name="password" className="form-control" placeholder="Password" id="id_password" />
                                    </div>
                                </div>
                                <div className="login-form-row flex">
                                    <button className="button button--brand" type="submit">Login</button>
                                    <a href="/forgotpass" className="forgotpass"> Forget password?</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
