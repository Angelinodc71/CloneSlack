import React, { Component } from 'react';
import axios from 'axios';
import './App.css';
import 'semantic-ui-css/semantic.min.css';
import { Grid, GridColumn, Header, Icon, List } from 'semantic-ui-react';
import SidePanel from './components/SidePanel/SidePanel'
import ColorPanel from './components/ColorPanel/ColorPanel';
import MetaPanel from './components/MetaPanel/MetaPanel';
import Messages from './components/Messages/Messages';

class App extends Component {
  render(){
    return (
      <Grid columns="equal" className="app">
        <ColorPanel/>
        <SidePanel/>

        <GridColumn style={{ marginLeft:320 }}>
          <Messages/>
        </GridColumn>
        
        <GridColumn width={4}>
          <MetaPanel/>
        </GridColumn>
      </Grid>
    );
  }
}

export default App;
