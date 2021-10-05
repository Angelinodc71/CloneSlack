import React, { Component } from 'react'
import { Button, Form, FormField, Icon, Input, MenuItem, MenuMenu, Modal, ModalActions, ModalContent, ModalHeader } from 'semantic-ui-react'

export class Channels extends Component {
    state = {
        channels: [],
        modal: false
    }

    changeValueModal = () => this.setState({ modal: !this.state.modal })

    render() {
        const {channels, modal} = this.state

        return (
            <React.Fragment>
                <MenuMenu style={{paddingBottom: '2em'}}>
                    <MenuItem>
                        <span>
                            <Icon name="exchange"/> CHANNELS {' '}
                        </span>
                        ({channels.length}) <Icon name="add" onClick={this.changeValueModal}/>
                    </MenuItem>
                </MenuMenu>
                <Modal content open={modal}>
                    <ModalHeader>Add Channel</ModalHeader>
                    <ModalContent>
                        <Form>
                            <FormField>
                                <Input fluid label="Name" name="channelName" type="text" />
                            </FormField>
                            <FormField>
                                <Input fluid label="Description" name="channelDescription" type="text" />
                            </FormField> 
                        </Form>
                    </ModalContent>
                    <ModalActions>
                        <Button basic color='green' inverted onClick={this.changeValueModal}>
                            <Icon name='checkmark'/> Add
                        </Button>
                        <Button basic color='red' inverted onClick={this.changeValueModal}>
                            <Icon name='remove'/> Cancel
                        </Button>
                    </ModalActions>
                </Modal>
            </React.Fragment>
        )
    }
}

export default Channels
