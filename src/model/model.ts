type User ={
	id: number // PK
	email: string
	password: string
	username: string
}

type Item = {
	id: number //PK
	sellerId: number //FK User.id
	name: string
	description: string
	price: number 
	imageUrl: string
	isSold: boolean
}

type Order = { 
	id: number //PK
	buyerId: number //FK
	isCheckout: boolean
	checkoutDate: Date
	totalAmount: number
}

type OrderItems = [
	{
		id: number,
		orderId: number,
		itmeId: number
	}
]

type Review = {
	id: number
	reviewerId: number
	sellerId: number
	content: string
}