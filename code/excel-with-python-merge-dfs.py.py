import pandas as pd

df_countries = xl("countries_2002[#All]", headers = True)
df_cities = xl("cities_2002[#All]", headers = True)

# print(df_countries.columns)
# Select only the necessary columns from df_countries and df_cities
df_countries_subset = df_countries[['code', 'city_id']]
df_cities_subset = df_cities[['id', 'country_code']]

merged_df = pd.merge(df_countries_subset, df_cities_subset, left_on='code', right_on='country_code')
new_dataframe = merged_df[['code', 'city_id']]
new_dataframe.columns = ['Country', 'Capital']


#### ONE COUNTRY - ONE CAPITAL
import pandas as pd
df_countries = xl("countries_2002[#All]", headers=True)
df_cities = xl("cities_2002[#All]", headers=True)
df_countries = df_countries[df_countries['city_id'] != 'NULL']
df_countries['city_id'] = df_countries['city_id'].astype(int)

# Merge the two dataframes based on the common column
merged_df = pd.merge(df_countries, df_cities, left_on='city_id', right_on='id')
### STOP AND SEE here
# Create a new dataframe with only the 'Country' and 'Capital' columns
new_dataframe = merged_df[['name_x', 'name_y']]

# Rename the columns
new_dataframe.columns = ['Country', 'Capital']

### Just in case
import pandas as pd

df_countries = xl("countries_2002[#All]", headers = True)
df_cities = xl("cities_2002[#All]", headers = True)
df_countries = df_countries[df_countries['city_id'] != 'NULL']
df_countries.city_id = df_countries.city_id.astype(int)

#df_countries_subset = df_countries[['code','city_id']]
#df_cities_subset = df_cities[['id','country_code']]

merged_df = pd.merge(df_countries, df_cities,left_on='city_id', right_on='id')
country_capital_df = merged_df[['name_x', 'name_y']]
country_capital_df.columns = ['country','capital']
country_capital_df.loc[country_capital_df.country == 'Bulgaria', 'capital'] = 'Sofia'
country_capital_df
