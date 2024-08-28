import React, { Component } from 'react';

export class Home extends Component {
	static displayName = Home.name;

	render() {
		return (
			<div>
				<h1>Ассоциация</h1>
				<h1>русскоязычных</h1>
				<h1>книжных</h1>
				<h1>клубов</h1>
				<img src="/bookshelf2.png" />
			</div>
		);
	}
}
