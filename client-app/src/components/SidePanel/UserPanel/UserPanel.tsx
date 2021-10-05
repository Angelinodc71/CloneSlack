import React from 'react'
import { Dropdown, Grid, GridColumn, GridRow, Header, HeaderContent, Icon } from 'semantic-ui-react'

export const UserPanel = () => {
    const dropdownOptions = () => [
        {
        key: 'user',
        text: (
                <span>
                    Logged as: <strong>User</strong>
                </span>
            ),
            disabled: true    
        },
        {
            key: 'avatar',
            text: (
                <span>
                    Change avatar
                </span>
            ),
            disabled: true
        }
    ]

    return (
        <Grid style={{ background: '#4c3c4c', margin: 0}}>
            <GridColumn>
                <GridRow style={{ padding:0, margin:0}}>
                <Header inverted floated="left" as="h2">
                    <Icon name="code"/>
                    <HeaderContent>Slack Clone</HeaderContent>
                </Header>
                </GridRow>
                <Header 
                    as='h4'
                    inverted
                    style={{ padding:'2em 0.25em 0.25em 0.25em' }}>
                    <Dropdown 
                        trigger={<span>User</span>}
                        options={dropdownOptions()}/>
                </Header>
            </GridColumn>
        </Grid>
    )
}

export default UserPanel
