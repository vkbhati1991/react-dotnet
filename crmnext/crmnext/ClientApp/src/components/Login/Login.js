import React from 'react';
import { LoginImage } from "./LoginImage";
import { LoginContent } from "./LoginContent";
import { LoginForm } from "./LoginForm";

export const Login = () => {
    return (
        <div className="login-container">
            <div className="login-row">
                <LoginImage />
                <div className="login-form bg-white">
                    <div className="login-contnet">
                        <LoginContent />
                        <LoginForm />
                    </div>
                </div>
            </div>
        </div>
    );
}
