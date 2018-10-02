import * as React from "react";
import "./../assets/scss/App.scss";

const reactLogo = require("./../assets/img/react_logo.svg");

export interface AppProps {
}

export default class App extends React.Component<AppProps, undefined> {
    render() {
        return (
            <div className="app">
                <h1>Hello Studio Receptionist AI!</h1>
                <p className="app__wall">Build Environment: {ENV}</p>
                <p className="app__wall">Configuration: {JSON.stringify(CONFIG)}</p>
                <img src={reactLogo} className="app__logo"/>
            </div>
        );
    }
}
