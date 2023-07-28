import React, { Component } from 'react';
import MM1NForm from './MM1NForm';
import MetricsTable from '../../Components/Shared/MetricsTable';

export class MM1N extends Component {
    constructor(props) {
        super(props);
        this.state = {
            metrics: {},
            loading: true
        };
    }

    populateMetrics = async (inputs) => {
        console.log(inputs);
        const response = await fetch('queue/mm1n', {
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
                <MM1NForm populateMetrics={this.populateMetrics} />
                {contents}
            </div>
        );
    }
}
