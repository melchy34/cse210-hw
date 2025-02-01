class Address:
    def __init__(self, street_address, city, state_province, country):
        self._street_address = street_address
        self._city = city
        self._state_province = state_province
        self._country = country

    def is_in_usa(self):
        return self._country == "USA"

    def get_full_address(self):
        return f"{self._street_address}\n{self._city}, {self._state_province}\n{self._country}"


class Customer:
    def __init__(self, name, address):
        self._name = name
        self._address = address

    def is_in_usa(self):
        return self._address.is_in_usa()

    def get_name(self):
        return self._name

    def get_address(self):
        return self._address.get_full_address()


class Product:
    def __init__(self, name, product_id, price, quantity):
        self._name = name
        self._product_id = product_id
        self._price = price
        self._quantity = quantity

    def get_total_cost(self):
        return self._price * self._quantity

    def get_name(self):
        return self._name

    def get_product_id(self):
        return self._product_id


class Order:
    def __init__(self, customer):
        self._customer = customer
        self._products = []

    def add_product(self, product):
        self._products.append(product)

    def calculate_total_cost(self):
        total_product_cost = sum([product.get_total_cost() for product in self._products])
        shipping_cost = 5 if self._customer.is_in_usa() else 35
        return total_product_cost + shipping_cost

    def get_packing_label(self):
        packing_label = "Packing Label:\n"
        for product in self._products:
            packing_label += f"{product.get_name()} (ID: {product.get_product_id()})\n"
        return packing_label

    def get_shipping_label(self):
        return f"Shipping Label:\n{self._customer.get_name()}\n{self._customer.get_address()}"


# Create some products
product1 = Product("Laptop", 101, 900, 1)
product2 = Product("Mouse", 102, 20, 2)
product3 = Product("Keyboard", 103, 50, 1)

# Create an address
address1 = Address("1234 Elm St", "Springfield", "IL", "USA")
address2 = Address("5678 Oak St", "Toronto", "ON", "Canada")

# Create customers
customer1 = Customer("John Doe", address1)
customer2 = Customer("Jane Smith", address2)

# Create orders
order1 = Order(customer1)
order1.add_product(product1)
order1.add_product(product2)

order2 = Order(customer2)
order2.add_product(product2)
order2.add_product(product3)

# Display results for the first order
print("Order 1:")
print(order1.get_packing_label())
print(order1.get_shipping_label())
print(f"Total cost: ${order1.calculate_total_cost()}")
print("\n" + "-"*40 + "\n")

# Display results for the second order
print("Order 2:")
print(order2.get_packing_label())
print(order2.get_shipping_label())
print(f"Total cost: ${order2.calculate_total_cost()}")
