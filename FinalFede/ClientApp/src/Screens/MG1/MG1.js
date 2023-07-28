import React, { Component } from 'react';
import MG1Form from './MG1Form';
import MetricsTable from '../../Components/Shared/MetricsTable';

export class MG1 extends Component {
    constructor(props) {
        super(props);
        this.state = {
            metrics: {},
            loading: true
        };
    }

    populateMetrics = async (inputs) => {
        const response = await fetch('queue/mg1', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json;charset=utf-8'
            },
            body: JSON.stringify(inputs)
        });

        const data = await response.json();
        this.setState({ metrics: data, loading: false });
    }

    render() {
        let contents = this.state.loading ? <></>
            : <MetricsTable metrics={this.state.metrics} />;

        return (
            <div>
                <MG1Form populateMetrics={this.populateMetrics} />
                {contents}
            </div>
        );
    }
}
