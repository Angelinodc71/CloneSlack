import React, { Component } from 'react';
import axios from 'axios';
import './App.css';
import 'semantic-ui-css/semantic.min.css';
import { Header, Icon, List } from 'semantic-ui-react';

class App extends Component {
  
  state = {
    channels: []
  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/channels').then((response) => {
      this.setState({
        channels: response.data
      })
    })
  }

  render(){
    return (
      <div>
        <Header as="h2" icon>
        <Icon name="users"></Icon>
          Clone Slack
          <Header.Subheader>
             Programmation languages
          </Header.Subheader>
        </Header>
        <List>
          {this.state.channels.map((value: any) => (
            <List.Item key={value.id}>{value.name}</List.Item>
          ))}
        </List>
      </div>
    );
  }
}

export default App;
